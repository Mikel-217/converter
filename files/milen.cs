using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MAIN;
using MILFS;

namespace MILE {

    public class Mile {
        

        public void milestart() {
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Geben Sie die Meilen an um diese in Kilometer umzurechnen: \n");
            Console.WriteLine("-----------------------------------------\n");
            milenstart();
            
            Console.Title = "Umrechner";
        }

        public void milenstart() {
            double kilometemile = 1.60934;

            /* Variabeln */
            string tmpmilen;
            double inputputmilen = 0;
            double finalmilen = 0;

            /* Input */
            tmpmilen = Console.ReadLine();

            if(tmpmilen == null) {
                Console.WriteLine("Error");
            } else {

            /* Umrechnen */
            inputputmilen = Convert.ToDouble(tmpmilen);

            /* Berechnen */
            finalmilen = inputputmilen * kilometemile;

            Console.WriteLine("Die Entfernung beträgt in kilometern: " + finalmilen);
            milensta();

            }
        }

        public void milensta() {
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
                    milenstart();
                    break;
                default:
                    break;
            }

        }
    }

}