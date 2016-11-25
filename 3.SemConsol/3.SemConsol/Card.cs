using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemConsol
{
    public class Card
    {
        public string CardID { get; set; }

        public Card(string cardId)
        {
            CardID = cardId;
        }

        public Card()
        {
            
        }

        public override string ToString()
        {
            return $"CardID: {CardID}";
        }
    }
}
