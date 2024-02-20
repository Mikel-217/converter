using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MAIN;
using MILE;

namespace MILFS {

    public class Miles {
        double kilometer = 1.60934;

        public void startm() {
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Geben Sie die Meilen per hour an, um in KMh zu berechnen: \n");
            Console.WriteLine("-----------------------------------------\n");
            input();
        }
        public void input() {
            /* Variabeln */
            string tmp;
            double inputput = 0;
            double final = 0;

            /* Input */
            tmp = Console.ReadLine();

            if(tmp == null) {
                Console.WriteLine("Error");
            } else {

            /* Umrechnen */
            inputput = Convert.ToDouble(tmp);

            /* Berechnen */
            final = inputput * kilometer;

            Console.WriteLine("Die Geschwindigkeit in KM/h beträgt: " + final);
            milesa();
            }
        }

        public void milesa() {
            string tmpmilesa;
            int tmpintmile = 0;

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("1 Hauptmenü");
            Console.WriteLine("2 Mehr berechnen");
            Console.WriteLine("-----------------------------------------\n");

            tmpmilesa = Console.ReadLine();

            tmpintmile = Convert.ToInt32(tmpmilesa);

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