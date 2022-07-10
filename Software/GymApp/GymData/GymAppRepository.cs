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
                currentUser = user;

                context.SaveChanges();
            }
        }
        public bool LogPayment(Payment payment)
        {
            using (var context = new PI2212_DBEntities())
            {

                context.Payments.Add(payment);
                int res = context.SaveChanges();
                if(res > 0)
                {
                    return true;
                }
            }
            return false;
        }

        
        public List<Bill> GetUnpaidBills(User user)
        {
            var query = from u in user.Bills
                        where u.user_id == user.user_id && u.payed == 0
                        select u;
            List<Bill> unpaidBills = query.ToList();
            return  unpaidBills;
        }

        public List<Bill> GetPaidBills(User user)
        {
            var query = from u in user.Bills
                        where u.user_id == user.user_id && u.payed == 1
                        select u;
            List<Bill> paidBills = query.ToList();
            return paidBills;
        }

        public void GenerateBill()
        {

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
                            where n.User == user && n.sent == 0 
                            select n;

                List<Notification> notifications = query.ToList();
                return notifications;
            }
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

        public Bill GetLastBill(User user)
        {
            using (var context = new PI2212_DBEntities())
            {
                var query = from b in context.Bills
                            where b.User == user
                            orderby b.due_date descending
                            select b;

                Bill bill = query.First();
                return bill;
            }
        }

    }
}
