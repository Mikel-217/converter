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

            Console.WriteLine("-----------------------------------------\n" +
                "Bit in Bytes umrechen \n" +
                "1 Bit in Bytes \n" +
                "2 Bytes in Bit \n" +
                "-----------------------------------------\n");
            inputbit();

        }

        void inputbit() {

            int inputbi = 0;
            
            Console.WriteLine("Option wählen:\n");
            
            inputbi = Convert.ToInt32(Console.ReadLine()!);
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
            
            int bit2 = 0; 
            int finalbit = 0;

            Console.WriteLine("Bitte Bits angeben: \n");
            bit2 = Convert.ToInt32(Console.ReadLine()!);

            finalbit = bit2 * 8;
            Console.WriteLine($"Ergebnis: {finalbit} \n");
            
            bitstart();
        }

        void bybit() {
            int bit3 = 0;
            int finalbit2 = 0;
            Console.WriteLine("Bitte Bytes angeben: \n");
            
            bit3 = Convert.ToInt32(Console.ReadLine()!);
            finalbit2 = bit3 / 8;
            Console.WriteLine($"Deine Anzahl an Bits entspricht: {finalbit2} \n");

            bitstart();
        }

        void bitstart() {
            int backm = 0;
            Console.WriteLine("-----------------------------------------\n" +
                "1 Hauptmenü \n" +
                "2 Mehr berechnen \n" +
                "-----------------------------------------\n");
            backm = Convert.ToInt32(Console.ReadLine()!);

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