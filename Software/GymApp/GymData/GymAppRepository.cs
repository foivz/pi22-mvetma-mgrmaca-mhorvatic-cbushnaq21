using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymData
{
    public class GymAppRepository
    {

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

    }
}
