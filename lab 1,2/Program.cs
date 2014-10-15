using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 25; ++a) // skapar  en variabel och former till hur lång raden ska vara

            {



                switch (a % 3)  // ska kunna ..mellan alla cases
                {
                    case 0:

                        Console.ForegroundColor = ConsoleColor.Yellow; // raden som ska vara gul

                        break; // den stannar sedan fortsäter den

                    case 1:

                        Console.ForegroundColor = ConsoleColor.White;

                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
 }
                if (a % 2 == 1) // mellan rum 

                {

                    Console.Write(" ");
                }

                for (int r = 0; r < 39; r++)
                {
                    Console.Write("* ");
                }

                    

                }
               Console.WriteLine(); 
            
    }


        }
    }


