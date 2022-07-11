using GymData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GymAppService
{
    public partial class GymAppService : ServiceBase
    {
        GymAppRepository gymAppRepository;
        public GymAppService()
        {
            gymAppRepository = new GymAppRepository();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 10000; //10s
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            List<User> users = gymAppRepository.GetAllUsers();
            SendAllNotifications(users);
            GenerateBills(users);
            SendAppointmentReminder();
        }

        private void GenerateBills(List<User> users)
        {
            foreach (User user in users)
            {
                Bill bill = gymAppRepository.GetLastBill(user);
                Bill newBill = new Bill();
                if (bill == null)
                {
                
                    newBill.amount = 199.99;
                    newBill.due_date = user.registration_date.AddDays(30);
                    newBill.user_id = user.user_id;
                    gymAppRepository.CreateBill(newBill);
                }
                else if(bill.due_date.Month == DateTime.Now.Month)
                {

                    newBill.amount = 199.99;
                    newBill.due_date = bill.due_date.AddDays(30);
                    bill.User = user;
                    gymAppRepository.CreateBill(bill);
                }
                
            }
        }

        private void SendAllNotifications(List<User> users)
        {
            
            foreach (User user in users)
            {
                List<Notification> notifications = gymAppRepository.GetUserNotifications(user);
                foreach (Notification notification in notifications)
                {
                    SendEmail(user.email, notification);
                    gymAppRepository.SetNotificationSent(notification);
                }
                
            }
        }

        private void SendAppointmentReminder()
        {
            List<Appointment> appointments = gymAppRepository.GetAppointments();
            foreach (Appointment appointment in appointments)
            {
                foreach(User user in appointment.Users)
                {
                    DateTimeOffset dateTimeOffset1 = new DateTimeOffset(appointment.start_time.Value.ToLocalTime());
                    DateTimeOffset dateTimeOffset2 = DateTimeOffset.Now;

                    long time1 = dateTimeOffset1.ToUnixTimeSeconds();
                    long time2 = dateTimeOffset2.ToUnixTimeSeconds();
                    if( time1-time2 < 86400 && time1-time2 > 86381 )
                    {
                        Notification notification = new Notification();
                        notification.reminder_description = "Reminder for appointment: " + appointment.appointment_description +
                            ", " + 
                            appointment.start_time.ToString();
                        SendEmail(user.email,notification);
                    }
                }
            }
        }

        protected override void OnStop()
        {
        }
        protected void SendEmail(string toEmail, Notification notification)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.next-cloud.ml");
            mail.From = new MailAddress("pi@next-cloud.ml");
            mail.To.Add(toEmail);
            mail.Body = notification.reminder_description;

            mail.Subject = "GymApp notification";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pi@next-cloud.ml", "mJ5PNFZOdE");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);

        }

        public void RunAsConsole(string[] args)
        {
            OnStart(args);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            OnStop();
        }
    }
}
