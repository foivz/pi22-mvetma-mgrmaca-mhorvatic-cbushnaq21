using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic.Interfaces
{
    public interface ICoachController
    {
        bool AddNewCoach(string name, string surname, string education, string coachNumber, string coachEmail);
        bool UpdateCoach(string name, string surname, string education, string coachNumber, string coachEmail);
        bool DeleteCoach(string name, string surname, string education, string coachNumber, string coachEmail);

    }
}
