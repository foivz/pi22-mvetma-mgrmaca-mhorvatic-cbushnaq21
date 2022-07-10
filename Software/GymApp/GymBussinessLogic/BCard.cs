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
           
            cards.Add(new BCard("1111", "0724", 708));
            cards.Add(new BCard("2222", "0823", 530));
            cards.Add(new BCard("3333", "0125", 476));
        }

        public List<BCard> cards = new List<BCard>();
        public BCard()
        {

        }
    }
}
