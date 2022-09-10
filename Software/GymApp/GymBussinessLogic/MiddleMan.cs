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
                bUser.description = user.description;
                bUser.profile_pic = user.profile_pic;
                Console.WriteLine("PROFILE PIC "+user.profile_pic);

                CurrentBUser = bUser;
            }
           
            return CurrentBUser;
        }

        // Marko Grmača ----------------------------------------------------------------------

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
        // Mislav Vetma -------------------------------------------------------------
        public void SaveEditedData()
        {
            GymAppRepository gymAppRepository = new GymAppRepository();

            BUser bUser = CurrentBUser;
            User user = new User();
            user.user_id = bUser.user_id;
            user.user_name = bUser.user_name;
            user.user_surname = bUser.user_surname;
            user.username = bUser.username;
            user.email = bUser.email;
            user.passwordium = bUser.passwordium;
            user.role_id = bUser.role_id;
            user.phone = bUser.phone;
            user.education = bUser.education;
            user.registration_date = bUser.registration_date;
            user.description = bUser.description;
            user.profile_pic = bUser.profile_pic;

            gymAppRepository.EditCoachData(user);
        }

        // Marko Grmača -----------------------------------------------------------------
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
            bUser.description = user.description;
            bUser.profile_pic = user.profile_pic;
            bUser.role_id = 3;


            return gymAppRepository.RegisterUser(bUser);
        }

        public bool Login(string username, string password)
        {
            bool res = new GymAppRepository().Login(username, password);
            GetCurrentUser();
            return res;
        }

        // Mislav Vetma ----------------------------------------------------------------------
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
                Console.WriteLine("ALOOOO"+bbill.user_id);
                bUnpaidBills.Add(bbill);
            }
            Console.WriteLine("RETURN unpaid");

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
                bPaidBills.Add(bbill);
            }

            return bPaidBills;
        }

        public bool CheckCard(BCard card)
        {
            List<BCard> cards = new List<BCard>();
            cards = new List<BCard>();
            cards.Add(new BCard("1111", "0724", 708));
            cards.Add(new BCard("2222", "0823", 530));
            cards.Add(new BCard("3333", "0125", 476));
            foreach (var c in cards)
            {
                if(card.BCardNumber.Equals(c.BCardNumber) &&
                card.BValidThru.Equals(c.BValidThru)&&
                card.BCCVNumber.Equals(c.BCCVNumber))
                {
                    return true;
                }

                
            }
            BCard found = null;
            found = cards.Find(c => c.BValidThru.Equals(card.BValidThru) && c.BCardNumber.Equals(card.BCardNumber) && c.BCCVNumber == card.BCCVNumber);
            if (found != null) return true;
            return false;

        }

        public void GeneratePDF(BBill bill)
        {
            DateTime paidTime = DateTime.UtcNow.Date;
            string html = $@"
                        <h1> Company name XY </h1> <hr>

                        <div>
                            OIB: XXXXXXXXXX <br>
                            Adress: Street street 7 <br>
                            IBAN:  HR Too many numbers <br>
                        </div>

                        <div align=""right"">
                            Name and surname: {CurrentBUser.user_name +" "+ CurrentBUser.user_surname} <br>
                            Phone number: {CurrentBUser.phone} <br>
                            e-mail: {CurrentBUser.email} <br>
                        </div>
                        <br><br><hr style=""border-width: 3px""> <br><br>

                        <table width=""100%"" border=1>

                            <tr align=""left"">
                                <th>Service</th>
                                <th >Amount</th>
                                <th>Price</th>
                            </tr>
                            <tr>
                                <td>Membership fee</td>
                                <td>1</td>
                                <td>{bill.amount} HRK</td>
                            </tr>
                        </table>
                        <br><br><hr style=""border-width: 3px""><br><br>
                        <div align=""right"">
                            Price: 199.99 HRK   <br>
                            Due date: {paidTime}
                        </div>
                        ";

            string v = bill.bill_id.ToString();
            var Renderer = new ChromePdfRenderer();
            Renderer.RenderHtmlAsPdf(html).SaveAs("Invoice_" + v+".pdf");
            SendEmail("Invoice_" + v + ".pdf");

        }

        public void SendEmail(string filename)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.next-cloud.ml");
            mail.From = new MailAddress("pi@next-cloud.ml");
            mail.To.Add(CurrentBUser.email);
            mail.Subject = "PDF Bill";

            mail.Body = "This is automated mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(filename);
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("pi@next-cloud.ml", "mJ5PNFZOdE");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);
        }

        public void LogPayment(BBill bill)
        {
            Bill payedBill = new Bill();
            Payment payment = new Payment();
            payment.bill_id = bill.bill_id;
            payment.amount = bill.amount;
            payment.date_payed = DateTime.Now.Date;
            GymAppRepository gymAppRepository = new GymAppRepository();
            gymAppRepository.LogPayment(payment);
            payedBill.bill_id = bill.bill_id;
            gymAppRepository.PayBill(payedBill);
            Console.WriteLine("Log payment 1");

        }
    }
}
