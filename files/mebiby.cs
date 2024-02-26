using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using MAIN;


namespace MEBIBYTE {

    public class Mebibyte {

        public void mebistart() {

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Bitte auswäheln: \n");
            Console.WriteLine("1 Mebibyte zu Megabyte\n");
            Console.WriteLine("2 Megabyte zu Mebibyte\n");
            Console.WriteLine("-----------------------------------------\n");

            inputmeb();
        }

        void inputmeb() {

            int inp = 0;
            string tempmeb;

            tempmeb = Console.ReadLine();

            inp = Convert.ToInt32(tempmeb);

            switch (inp) {
                case 1:
                    meby();
                    break;
                case 2:
                    mebg();
                    break;
                default:
                    break;
            }
        }

        void meby() {
            
            int mbi1 = 0;
            double final = 0;
            string tmpmby;

            Console.WriteLine("Bitte geben Sie Mebibytes an: \n");
            tmpmby = Console.ReadLine();

            mbi1 = Convert.ToInt32(tmpmby);

            final = mbi1 * 1.049;

            Console.WriteLine("Sind: " + final + "Megabyte\n");

            startmebi();
        }

        void mebg() {
            
            int mbi = 0;
            double final = 0;
            string tmpmby;

            Console.WriteLine("Bitte geben Sie Mebibytes an: \n");
            tmpmby = Console.ReadLine();

            mbi = Convert.ToInt32(tmpmby);

            final = mbi / 1.049;

            Console.WriteLine(mbi + " Sind: " + final + "Mebibyte\n");

            startmebi();
        }

        void startmebi() {

            string tmpmilen;
            int tmpintmilen = 0;

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("1 Hauptmenü");
            Console.WriteLine("2 Mehr berechnen");
            Console.WriteLine("-----------------------------------------\n");

            tmpmilen = Console.ReadLine();

            tmpintmilen = Convert.ToInt32(tmpmilen);

            switch (tmpintmilen) {
                case 1:  
                    maininout pr = new maininout();
                    pr.mainout();
                    break;
                case 2:
                    mebistart();
                    break;
                default:
                    break;
            }
        }
    }
}