using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MILFS;
using MILE;
using DOLLAR;
using FAHREN;
using BIT;
using MEBIBYTE;


namespace MAIN {
    
    public class Program {


        public static void Main(string[] args) {
            
            Console.Title = "Umrechner";
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
            Console.WriteLine("3 Fahrenheiten zu Celsius\n");
            Console.WriteLine("4 Bit zu Bytes\n");
            Console.WriteLine("5 Megabyte zu Mebibyte\n");
            Console.WriteLine("6 Dollar zu Euro\n");
            Console.WriteLine("7 Exit\n");
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
    	            fahren fah = new fahren();
                    fah.startenfah();
                    break;
                case 4:
                    bitb bit = new bitb();
                    bit.startbit();
                    break;
                case 5:
                    Mebibyte meb = new Mebibyte();
                    meb.mebistart();
                    break;
                case 6:
                    dtoe dollar = new dtoe();
                    dollar.startdoll();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}