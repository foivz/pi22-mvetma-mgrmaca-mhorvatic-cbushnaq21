using GymData;
using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;




namespace GymBussinessLogic
{
    public class MiddleMan
    {
        //Mislav Vetma ---------------------------------------------------------------------------
        public static BUser CurrentBUser { get; set; }
        public static User user;

        public MiddleMan()
        {
            user = GymAppRepository.CurrentUser;
        }
        public static BUser GetCurrentUser()
        {
            User user = GymAppRepository.CurrentUser;
            BUser bUser = new BUser();
            if(user != null)
            {
                bUser.user_id = user.user_id;
                bUser.user_name = user.user_name;
                bUser.user_surname = user.user_surname;
                bUser.username = user.username;
                bUser.email = user.email;
                bUser.passwordium = user.passwordium;
                bUser.role_id = user.role_id;
                bUser.phone = user.phone;
                bUser.education = user.education;
                bUser.registration_date = user.registration_date;
                CurrentBUser = bUser;
            }
           
            return CurrentBUser;
        }

        public bool ResetPassword(string email)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string password = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            bool res = new GymAppRepository().SaveNewPassword(email, password);
            if (res)
            {
                try
                {
                    SendPasswordResetEmail(email, password);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        private void SendPasswordResetEmail(string email, string password)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.next-cloud.ml");
            mail.From = new MailAddress("pi@next-cloud.ml");
            mail.To.Add(email);
            mail.Subject = "GymApp new password";

            mail.Body = "New password: "+password;


            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pi@next-cloud.ml", "mJ5PNFZOdE");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);
        }

        public void Logout()
        {
            CurrentBUser = null;
            GymAppRepository.CurrentUser = null;
        }

        public void SaveEditedData()
        {
            GymAppRepository gymAppRepository = new GymAppRepository();

            BUser user = CurrentBUser;
            User bUser = new User();
            bUser.user_id = user.user_id;
            bUser.user_name = user.user_name;
            bUser.user_surname = user.user_surname;
            bUser.username = user.username;
            bUser.email = user.email;
            bUser.passwordium = user.passwordium;
            bUser.role_id = user.role_id;
            bUser.phone = user.phone;
            bUser.education = user.education;
            bUser.registration_date = user.registration_date;

            gymAppRepository.EditCoachData(bUser);
        }

        public bool Register(BUser user)
        {
            GymAppRepository gymAppRepository = new GymAppRepository();
            User bUser = new User();
            bUser.user_id = user.user_id;
            bUser.user_name = user.user_name;
            bUser.user_surname = user.user_surname;
            bUser.username = user.username;
            bUser.email = user.email;
            bUser.passwordium = user.passwordium;
            bUser.role_id = user.role_id;
            bUser.phone = user.phone;
            bUser.education = user.education;
            bUser.registration_date = user.registration_date;
            bUser.role_id = 3;


            return gymAppRepository.RegisterUser(bUser);
        }

        public bool Login(string username, string password)
        {
            bool res = new GymAppRepository().Login(username, password);
            GetCurrentUser();
            return res;
        }

        public List <BBill> UnpaidBills()
        {
            GymAppRepository gymAppRepository = new GymAppRepository();
            List<Bill> UnpaidBills;
            if (GymAppRepository.CurrentUser.Bills != null)
            {
                UnpaidBills = gymAppRepository.GetUnpaidBills(GymAppRepository.CurrentUser);
            }
            else
            {
                return null;
            }
             
            List<BBill> bUnpaidBills = new List<BBill>();

            foreach (Bill b in UnpaidBills)
            {
                BBill bbill = new BBill();
                bbill.bill_id = b.bill_id;
                bbill.user_id = b.user_id;
                bbill.due_date = b.due_date;
                bbill.amount = b.amount;
                bbill.payed = b.payed;
            }

            return bUnpaidBills;
        }

        public List<BBill> PaidBills()
        {
            GymAppRepository gymAppRepository = new GymAppRepository();
            List<Bill> PaidBills = gymAppRepository.GetPaidBills(user);
            List<BBill> bPaidBills = new List<BBill>();


            foreach(Bill b in PaidBills)
            {
                BBill bbill = new BBill();
                bbill.bill_id = b.bill_id;
                bbill.user_id = b.user_id;
                bbill.due_date = b.due_date;
                bbill.amount = b.amount;
                bbill.payed = b.payed;
            }

            return bPaidBills;
        }

        public bool CheckCard(BCard card)
        {

            foreach(var c in card.cards)
            {
                if(card.BCardNumber.Equals(c.BCardNumber) &&
                card.BValidThru.Equals(c.BValidThru)&&
                card.BCCVNumber.Equals(c.BCCVNumber))
                {
                    return true;
                }

                
            }

            return false;

        }

        public void GeneratePDF(BBill bill)
        {
            DateTime paidTime = DateTime.UtcNow.Date;
            string html = "<h2> Bill id: " + bill.bill_id + "<h2>" +
                          "<h4> Name: " + CurrentBUser.user_name + "<h4>" +
                          "<h4> Surname: " + CurrentBUser.user_surname + "<h4>"+
                          "<h4> Amount: " + bill.amount + " HRK <h4>"+
                          "<h4> Due date: " + bill.due_date + "<h4>"+
                          "<h4> Date paid: " + paidTime + "<h4>"+
                          "<h3> Thank you for paying your invoice! XY Gym  <h3>";

            string v = bill.bill_id.ToString();
            var Renderer = new ChromePdfRenderer();
            Renderer.RenderHtmlAsPdf(html).SaveAs("Invoice: " + v);
            SendEmail();

        }

        public void SendEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.next-cloud.ml");
            mail.From = new MailAddress("pi@next-cloud.ml");
            mail.To.Add(CurrentBUser.email);
            mail.Subject = "PDF Bill";

            mail.Body = "This is automated mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("GeneratePDF.pdf");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pi@next-cloud.ml", "mJ5PNFZOdE");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);
        }

        public void LogPayment(BBill bill)
        {
            Payment payment = new Payment();
            payment.bill_id = bill.bill_id;
            payment.amount = bill.amount;
            payment.date_payed = DateTime.Now.Date;

        }
    }
}
