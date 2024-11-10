using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Linq;
using MAIN;
using MILEN;

namespace MILE {

    public class Mile {
        

        public void milestart() {
            Console.WriteLine("-----------------------------------------\n" +
                "Geben Sie die Meilen an um diese in Kilometer umzurechnen:\n" +
                "-----------------------------------------\n");
            milenstart();
            
            Console.Title = "Umrechner";
        }

        public void milenstart() {
            
            double kilometemile = 1.60934;
            double finalmilen = 0;
            double inputputmilen = Convert.ToDouble(Console.ReadLine()!);
            
            finalmilen = inputputmilen * kilometemile;

            Console.WriteLine($"Die Entfernung beträgt in kilometern: {finalmilen}");
            milensta();
            
        }

        public void milensta() {
            string tmpmilen;
            int tmpintmilen = 0;

            Console.WriteLine("-----------------------------------------\n" +
                "1 Hauptmenü \n" +
                "2 Mehr berechnen \n" +
                "-----------------------------------------\n");
            
            tmpintmilen = Convert.ToInt32(Console.ReadLine()!);

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