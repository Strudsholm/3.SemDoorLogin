using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemConsol
{
    public class Log
    {
        public DateTime DateTime { get; set; }
        public int DoorID { get; set; }
        public string CardID { get; set; }
        public bool AccesGranted { get; set; }

        public Log(DateTime dateTime, int doorId, string cardId, bool accesGranted)
        {
            DateTime = dateTime;
            DoorID = doorId;
            CardID = cardId;
            AccesGranted = accesGranted;
        }

        public override string ToString()
        {
            return $"DateTime: {DateTime}, DoorID: {DoorID}, CardID: {CardID}, AccesGranted: {AccesGranted}";
        }
    }
}
