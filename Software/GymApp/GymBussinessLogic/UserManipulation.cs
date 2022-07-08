using GymData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic
{
    public class UserManipulation
    {
      
        public static BUser GetCurrentUser()
        {
            User user =GymAppRepository.CurrentUser;
            BUser bUser = new BUser();
            bUser.user_name = user.user_name;
           
            return bUser;
        }

        public static Role GetCurrentRole()
        {
            return GymAppRepository.CurrentUserRole;
        }
    }
}
