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
        public static BUser CurrentBUser { get; set; }
        public static BUser GetCurrentUser()
        {
            User user = GymAppRepository.CurrentUser;
            BUser bUser = new BUser();
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
           
            return CurrentBUser;
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

       
    }
}
