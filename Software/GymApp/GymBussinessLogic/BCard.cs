using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBussinessLogic
{
    public class BCard
    {
        public string BCardNumber { get; set; }
        public string BValidThru { get; set; }
        public int BCCVNumber { get; set; }

        public BCard(string cardNumber, string validThru, int cCVNumber)
        {
            BCardNumber = cardNumber;
            BValidThru = validThru;
            BCCVNumber = cCVNumber;
            
        }

       
        public BCard()
        {
         
          
        }
    }
}
