using GymData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic
{
    public class BUser 
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string passwordium { get; set; }
        public int role_id { get; set; }
        public System.DateTime registration_date { get; set; }
        public string phone { get; set; }
        public string education { get; set; }
    }
}
