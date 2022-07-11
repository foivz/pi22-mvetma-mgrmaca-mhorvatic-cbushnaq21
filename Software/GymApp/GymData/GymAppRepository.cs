using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymData
{
    public class GymAppRepository
    {

// Mislav Vetma -------------------------------------------------------------------------
        public static User CurrentUser { get; set; }
        public void EditCoachData(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from u in context.Users
                            where u.user_id == user.user_id
                            select u;

                User currentUser = query.Single();
                currentUser.email = user.email;
                currentUser.username = user.username;
                currentUser.education = user.education;
                currentUser.user_name = user.user_name;
                currentUser.user_surname = user.user_surname;
                currentUser.phone = user.phone;

                CurrentUser = currentUser;

                context.SaveChanges();
            }
        }
        public bool LogPayment(Payment payment)
        {
            using (var context = new PI2212_DBEntities())
            {

                context.Payments.Add(payment);

                int res = context.SaveChanges();
                Console.WriteLine("Log payment 2: "+res);
                if (res > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void PayBill(Bill bill)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from u in context.Bills
                            where u.bill_id == bill.bill_id
                            select u;

                Bill b = query.Single();
                b.payed = 1;

                
                context.SaveChanges();
            }
        }

        
        public List<Bill> GetUnpaidBills(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from u in context.Bills
                            where u.user_id == user.user_id && u.payed != 1
                            select u;
                List<Bill> unpaidBills = query.ToList();
                return unpaidBills;
            }
            
        }

        public List<Bill> GetPaidBills(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from u in context.Bills
                            where u.user_id == user.user_id && u.payed == 1
                            select u;
                List<Bill> paidBills = query.ToList();
                return paidBills;
            }
            
        }

        public bool SaveNewPassword(string email, string password)
        {
            using (var context = new PI2212_DBEntities())
            {

                var query = from u in context.Users where u.email.Equals(email) select u;

                User user = query.Single();
                user.passwordium = password;
                int res = context.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
            }
            return false;
        }


        public bool CreateBill(Bill bill)
        {
            using (var context = new PI2212_DBEntities())
            {

                context.Bills.Add(bill);
                int res = context.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
            }
            return false;
        }
        // Marko Grmača -------------------------------------------------------------------------
        public List<User> GetAllUsers()
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from u in context.Users select u;

                List<User> users = query.ToList();
                return users;
            }
        }

        public List<Notification> GetUserNotifications(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from n in context.Notifications 
                            where n.user_id == user.user_id && n.sent == 0 
                            select n;

                List<Notification> notifications = query.ToList();
                return notifications;
            }
        }

        public bool Login(string username, string password)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from n in context.Users
                            where n.username.Equals(username.Trim()) && n.passwordium.Equals(password)
                            select n;

                CurrentUser = query.SingleOrDefault();
                if(CurrentUser != null)
                {
                    var query2 = from b in context.Bills where b.user_id == CurrentUser.user_id select b;
                    CurrentUser.Bills = query2.ToList();
                }
                if(CurrentUser!=null) return true;
            }
            return false;
        }

        public bool RegisterUser(User user)
        {
            using (var context = new PI2212_DBEntities())
            {

                context.Users.Add(user);
                int res = context.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Appointment> GetAppointments()
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from a in context.Appointments
                            select a ;

                List<Appointment> appointments = query.ToList();
                return appointments;
            }
        }

        public void SetNotificationSent(Notification notification)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from n in context.Notifications
                            where n.notification_id == notification.notification_id
                            select n;

                Notification notification1 = query.Single();
                notification1.sent = 1;
              

                context.SaveChanges();
            }
        }
        // Mislav Vetma ------------------------------------------------------------------------
        public Bill GetLastBill(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from b in context.Bills
                            where b.user_id == user.user_id
                            orderby b.due_date descending
                            select b;

                try
                {
                    Bill bill = query.First();
                    return bill;
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

    }
}
