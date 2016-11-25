using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemConsol
{
    public class Door
    {
        public int DoorID { get; set; }

        public Door()
        {
            
        }

        public Door(int doorId)
        {
            DoorID = doorId;
        }

        public override string ToString()
        {
            return $"DoorID: {DoorID}";
        }
    }
}
