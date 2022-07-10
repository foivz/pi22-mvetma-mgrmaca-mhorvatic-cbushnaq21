using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymData
{
    public class Card
    {
        public string CardNumber { get; set; }
        public string ValidThru { get; set; }
        public int CCVNumber { get; set; }

        public Card(string cardNumber, string validThru, int cCVNumber)
        {
            CardNumber = cardNumber;
            ValidThru = validThru;
            CCVNumber = cCVNumber;
            List<Card> cards = new List<Card>();
            cards.Add(new Card("1111", "0724", 708));
            cards.Add(new Card("2222", "0823", 530));
            cards.Add(new Card("3333", "0125", 476));
        }

        public Card()
        {

        }

        
        
        
    }
}
