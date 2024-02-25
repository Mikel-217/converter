using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using MAIN;


namespace BIT {

    public class bitb {

        public void startbit() {

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Bit in Bytes umrechen \n");
            Console.WriteLine("1 Bit in Bytes \n");
            Console.WriteLine("2 Bytes in Bit \n");
            Console.WriteLine("-----------------------------------------\n");
            inputbit();

        }

        void inputbit() {

            int inputbi = 0;
            string tmpbi;

            Console.WriteLine("Option wählen:\n");
            tmpbi = Console.ReadLine();

            inputbi = Convert.ToInt32(tmpbi);

            switch (inputbi) {
                case 1:
                    bitby();
                    break;
                case 2:
                    bybit();
                    break;
                default:
                    break;
            }
        }

        void bitby() {

            string tmpbit2;
            int bit2 = 0; 
            int finalbit = 0;

            Console.WriteLine("Bitte Bits angeben: \n");
            tmpbit2 = Console.ReadLine();

            bit2 = Convert.ToInt32(tmpbit2);

            finalbit = bit2 * 8;

            Console.WriteLine("Ergebnis: " + finalbit + "\n");
            
            bitstart();
        }

        void bybit() {
            
            string tmpbit3;
            int bit3 = 0;
            int finalbit2 = 0;

            Console.WriteLine("Bitte Bytes angeben: \n");
            tmpbit3 = Console.ReadLine();

            bit3 = Convert.ToInt32(tmpbit3);

            finalbit2 = bit3 / 8;

            Console.WriteLine("Deine Anzahl an Bits entspricht: " + finalbit2 + "\n");

            bitstart();
        }

        void bitstart() {
            int backm = 0;
            string backms;

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("1 Hauptmenü");
            Console.WriteLine("2 Mehr berechnen");
            Console.WriteLine("-----------------------------------------\n");
            backms = Console.ReadLine();

            backm = Convert.ToInt32(backms);

            switch (backm) {
                case 1:
                    maininout pr = new maininout();
                    pr.mainout();
                    break;
                case 2:
                    startbit();
                    break;
                default:
                    break;
            }
        }
    }
}