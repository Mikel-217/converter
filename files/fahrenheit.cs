using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using MAIN;


namespace FAHREN {

    public class fahren {
        public void startenfah() {

            Console.WriteLine("-----------------------------------------\n"+
                "Fahrenheiten in Celsius umrechen \n"+
                "1 Celsius in Fahrenheit \n"+
                "2 Fahrenheiten in Celsius \n"+
                "-----------------------------------------\n");

            inputfahr();
        }

        void inputfahr() {
            int inputfa = 0;
            
            Console.WriteLine("Option wählen: \n");

            inputfa = Convert.ToInt32(Console.ReadLine()!);

            switch (inputfa) {
                case 1:
                    celfa();
                    break;
                case 2:
                    facel();
                    break;
                default:
                    break;
            }
        }

        void celfa() {

            double cel1 = 0;
            double cel2 = 0;
            double finalfa1 = 0;

            Console.WriteLine("Geben Sie ihre Grad anzahl in Celsius an: \n");

            cel1 = Convert.ToDouble(Console.ReadLine()!);
            cel2 = cel1 * 9/5;
            finalfa1 = cel2 + 32;

            Console.WriteLine($"Das Ergebnis: {finalfa1} F");
            startenfah();
        }

        void facel() {
            
            double face1 = 0;
            double face2 = 0;
            double finalfa2 = 0;

            Console.WriteLine("Geben Sie eine Fahrenheit zahl an: \n");

            face1 = Convert.ToDouble(Console.ReadLine()!);
            face2 = face1 - 32;
            finalfa2 = face2 * 5/9;
            Console.WriteLine($"Das Ergebnis: {finalfa2} C");
            startenfah();
        }

        void startfah() {
            int instafah = 0;
            
            Console.WriteLine("-----------------------------------------\n"+
                "1 Hauptmenü \n"+
                "2 Mehr berechnen \n"+
                "-----------------------------------------\n");
            instafah = Convert.ToInt32(Console.ReadLine()!);

            switch (instafah) {
                
                case 1:
                    maininout pr = new maininout();
                    pr.mainout();
                    break;
                case 2:
                    startenfah();
                    break;
                default:
                    break;
            }

        }
    }
}


