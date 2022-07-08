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
        public static Role CurrentUserRole { get; set; }
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
    }
}
