using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _3.SemConsol
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card("abcde12345"));
            cards.Add(new Card("abcde12222"));
            cards.Add(new Card("abcde12233"));

            List<Door> doors = new List<Door>();
            doors.Add(new Door(2));
            doors.Add(new Door(23));
            doors.Add(new Door(234));


            bool Doorexists = false;

            while (true)
            {
                Console.WriteLine("What door are you trying to access?");
                int DoorID = Int32.Parse(Console.ReadLine());

                foreach (var d in doors)
                {
                    if (d.DoorID == DoorID)
                    {
                        Doorexists = true;
                    }
                }
                if (Doorexists)
                {
                    Console.WriteLine("Scan card");

                    bool Granted = false;
                    

                    string CardID = Console.ReadLine();

                    foreach (var c in cards)
                    {
                        if (c.CardID.Equals(CardID))
                        {
                            Granted = true;

                        }
                    }
                    if (Granted)
                    {
                        Console.WriteLine("Access Granted");
                    }
                    else
                    {
                        Console.WriteLine("Access Denied");
                    }
                    
                }




            }
        }
    }
}
