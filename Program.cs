using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MILES;
using MILE;


/* TODO: 
- bit zu bytes
- MB zu Mebibyte
- Fahrenheit zu Celcius
- Milen zu Kilometer
- Dollar zu Euro
- Euro zu Dollar
*/

namespace MAIN {
    
    public class Program {


        public static void Main(string[] args) {
            
            maininout man = new maininout();
            man.mainout();
            
        }
    }
    public class maininout {
        public void mainout() {
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Was möchten Sie berechnen/umrechnen?\n");
            Console.WriteLine("1 MPh zu KMh\n");
            Console.WriteLine("2 Milen zu Kilometer\n");
            Console.WriteLine("3 Fahrenheiten zu Celcius\n");
            Console.WriteLine("4 Bit zu Bytes\n");
            Console.WriteLine("5 Megabyte zu Mebibyte\n");
            Console.WriteLine("6 Dollar zu Euro\n");
            Console.WriteLine("Schreiben Sie eine Zahl rein um dieses auszuwählen:\n");
            Console.WriteLine("-----------------------------------------\n");

            mainput();

        }

        public void mainput() {

            string exit;

            int inputt = 0;
            string tmp2;

            tmp2 = Console.ReadLine();

            if (tmp2 == null) {

                Console.WriteLine("Error");
            }

            inputt = Convert.ToInt32(tmp2);

            switch (inputt) {

                case 1:
                    Miles startmi = new Miles();
                    startmi.startm();
                    break;
                case 2:
                    Mile startmile = new Mile();
                    startmile.milestart();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    break;
            }

        }
    }
}