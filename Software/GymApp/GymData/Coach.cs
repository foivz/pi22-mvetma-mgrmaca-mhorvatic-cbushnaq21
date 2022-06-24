using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymData
{
    public class Coach
    {
        public string CoachName { get; set; }
        public string CoachSurname { get; set; }
        public string CoachEducation { get; set; }
        public string CoachNumber { get; set; }
        public string CoachEmail { get; set; }

        public Coach(string coachName, string coachSurname, string coachEducation, string coachNumber, string coachEmail)
        {
            CoachName = coachName;
            CoachSurname = coachSurname;
            CoachEducation = coachEducation;
            CoachNumber = coachNumber;
            CoachEmail = coachEmail;
        }

        public Coach()
        {

        }
    }
}
