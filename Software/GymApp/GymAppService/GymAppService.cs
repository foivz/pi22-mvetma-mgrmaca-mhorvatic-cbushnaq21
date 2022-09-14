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
        private bool completedCycle = true;
        public GymAppService()
        {
            
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 60*60000; //svaki sat
            timer.Interval = 10000; //svaki sad
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            gymAppRepository = new GymAppRepository();
            Console.WriteLine("TIMER triggered");
            if (completedCycle)
            {
                Console.WriteLine(completedCycle+" completedCycle");
                completedCycle = false;
                List<User> users = gymAppRepository.GetAllUsers();
                SendAllNotifications(users);
                GenerateBills(users);
                SendAppointmentReminder();
                completedCycle = true;
            }
        }

        private void GenerateBills(List<User> users)
        {
            completedCycle = false;
            foreach (User user in users)
            {

                DateTime date = user.registration_date;

                do
                {
                    Console.WriteLine($"USER {user.user_surname}  DATE date date " + date);
                    Bill newBill = new Bill();
                    newBill.amount = 199.99;
                    newBill.due_date = date;
                    newBill.user_id = user.user_id;
                    newBill.payed = null;
                    bool res = gymAppRepository.CreateBill(newBill);
                    date = date.AddMonths(1);
                } while (date.CompareTo(DateTime.Now) < 0 && user.role_id > 2);

            }
        }

        private void SendAllNotifications(List<User> users)
        {
            
            foreach (User user in users)
            {
                List<Notification> notifications = gymAppRepository.GetUserNotifications(user);
                foreach (Notification notification in notifications)
                {
                    if (SendEmail(user.email, notification)) 
                    {
                        gymAppRepository.SetNotificationSent(notification);
                    }
                    
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
                    if( time1-time2 < 86400)
                    {
                        Notification notification = new Notification();
                        notification.user_id = user.user_id;
                        notification.notifcation_type_id = 2;
                        notification.reminder_description = "Reminder for appointment: " + appointment.appointment_description +
                            ", " + 
                            appointment.start_time.ToString();
            

                        //Console.WriteLine("SendEmail "+user.email+ " "+notification);
                        if (gymAppRepository.SaveNotification(notification) && SendEmail(user.email, notification))
                        {
                            gymAppRepository.SetNotificationSent(notification);
                        }
                    }
                }
            }
        }

        protected override void OnStop()
        {
        }
        protected bool SendEmail(string toEmail, Notification notification)
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

            try
            {
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

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
