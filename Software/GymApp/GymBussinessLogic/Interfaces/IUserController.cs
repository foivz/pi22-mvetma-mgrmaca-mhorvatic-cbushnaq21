using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic.Interfaces
{
    public interface IUserController
    {
        bool AddNewUser(string name, string surname, string email, string password);
        bool CheckUserCredentials(string email, string password);
        bool UpdateUserName(string name, string surname, string email, string password);
        bool DeleteuserName(string name, string surname, string email, string password);

    }
}
