using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MAIN;
using MILE;

namespace MILEN {

    public class Miles {
        double kilometer = 1.60934;

        public void startm() {
            Console.WriteLine("-----------------------------------------\n" +
                "Geben Sie die Meilen per hour an, um in KMh zu berechnen: \n" +
                "-----------------------------------------\n");
            input();
        }
        public void input() {
            
            double inputput = 0;
            double final = 0;
            inputput = Convert.ToDouble(Console.ReadLine()!);
            final = inputput * kilometer;

            Console.WriteLine($"Die Geschwindigkeit in KM/h beträgt: {final}");
            milesa();
        }

        public void milesa() {
            int tmpintmile = 0;
            Console.WriteLine("-----------------------------------------\n" +
                "1 Hauptmenü \n" +
                "2 Mehr berechnen \n" +
                "-----------------------------------------\n");
            tmpintmile = Convert.ToInt32(Console.ReadLine()!);
            switch (tmpintmile) {
                case 1:  
                    maininout pr = new maininout();
                    pr.mainout();
                    break;
                case 2:
                    startm();
                    break;
                default:
                    break;

            }

        }

    }
}