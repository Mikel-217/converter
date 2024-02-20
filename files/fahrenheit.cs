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

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Fahrenheiten in Celsius umrechen \n");
            Console.WriteLine("1 Celsius in Fahrenheit \n");
            Console.WriteLine("2 Fahrenheiten in Celsius \n");
            Console.WriteLine("-----------------------------------------\n");

            inputfahr();
        }

        void inputfahr() {
            int inputfa = 0;
            string tmpfah;

            Console.WriteLine("Option wählen: \n");
            tmpfah = Console.ReadLine();

            inputfa = Convert.ToInt32(tmpfah);

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

        }

        void facel() {
            double face1 = 0;
            double face2 = 0;
            double finalfa2 = 0;

            string tmpfah3;

            Console.WriteLine("Geben Sie eine Fahrenheit zahl an: \n");

            tmpfah3 = Console.ReadLine();

            face1 = Convert.ToInt32(tmpfah3);

            face2 = face1 - 32;
            finalfa2 = face2 * 5/9;

            Console.WriteLine("Das Ergebnis: " + finalfa2 + "C");
        }
    }
}


