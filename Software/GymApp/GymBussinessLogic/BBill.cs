using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic
{
    public class BBill
    {
        public int bill_id { get; set; }
        public System.DateTime due_date { get; set; }
        public double amount { get; set; }
        public Nullable<byte> payed { get; set; }
        public int user_id { get; set; }
    }
}
