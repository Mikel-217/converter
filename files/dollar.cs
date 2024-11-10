using System;
using System.Collections;
using MAIN;

namespace DOLLAR {

    public class dtoe{

        public void startdoll() {

            Console.WriteLine("-----------------------------------------\n"+
                "Bitte auswäheln: \n"+
                "1 Dollar zu Euro\n"+
                "2 Euro zu Dollar\n"+
                "-----------------------------------------\n");

            inputdoll();
        }

        void inputdoll() {
            int inpuint = 0;
            inpuint = Convert.ToInt32(Console.ReadLine()!);

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

            Console.WriteLine("Geben Sie Dollar an um es in Euro umzuwandeln: \n");
            dollar = Convert.ToDouble(Console.ReadLine()!);
            finaldoll = dollar * euro;

            Console.WriteLine($"Das Ergebnis: {finaldoll}");

            dollarsta();
        }

        /*Euro zu Dollar */
        void eudol() {
            double dollar2 = 0.92515;
            double euro2 = 0;
            double finaldoll2 = 0;

            Console.WriteLine("Geben Sie Euro an um es in Dollar umzuwandeln: \n");
            dollar2 = Convert.ToDouble(Console.ReadLine()!);

            finaldoll2 = euro2 / dollar2;

            Console.WriteLine($"Das Ergebnis: {finaldoll2}");
            dollarsta();
        }

        void dollarsta() {
            int backm = 0;
            Console.WriteLine("-----------------------------------------\n"+
                "1 Hauptmenü \n"+
                "2 Mehr berechnen \n"+
                "-----------------------------------------\n");
            backm = Convert.ToInt32(Console.ReadLine()!);
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