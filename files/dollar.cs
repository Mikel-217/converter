using System;
using System.Collections;
using MAIN;

namespace DOLLAR {

    public class dtoe{

        public void startdoll() {

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Bitte auswäheln: \n");
            Console.WriteLine("1 Dollar zu Euro\n");
            Console.WriteLine("2 Euro zu Dollar\n");
            Console.WriteLine("-----------------------------------------\n");

            inputdoll();
        }

        void inputdoll() {
            string tmpdoll;
            int inpuint = 0;

            tmpdoll = Console.ReadLine();

            inpuint = Convert.ToInt32(tmpdoll);

            switch (inpuint) {
                case 1:
                    doleu();
                    break;
                case 2: 
                    eudol();
                    break;
                default:
                    break;
            }
        }

        /*Dollar zu Euro*/
        void doleu() {
            double dollar = 0;
            double euro = 0.92515;
            double finaldoll = 0;    
            string tmpdolle;

            Console.WriteLine("Geben Sie Dollar an um es in Euro umzuwandeln: \n");
            tmpdolle = Console.ReadLine();
            dollar = Convert.ToDouble(tmpdolle);

            finaldoll = dollar * euro;

            Console.WriteLine("Das Ergebnis: " + finaldoll);

            dollarsta();
        }

        /*Euro zu Dollar */
        void eudol() {
            double dollar2 = 0.92515;
            double euro2 = 0;
            double finaldoll2 = 0;
            string tmpdolle2;

            Console.WriteLine("Geben Sie Euro an um es in Dollar umzuwandeln: \n");
            tmpdolle2 = Console.ReadLine();
            dollar2 = Convert.ToDouble(tmpdolle2);

            finaldoll2 = euro2 / dollar2;

            Console.WriteLine("Das Ergebnis: " + finaldoll2);

            dollarsta();
        }

        void dollarsta() {

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
                    startdoll();
                    break;
                default:
                    break;
            }
        }
    }
}