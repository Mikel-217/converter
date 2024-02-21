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
            double cel1 = 0;
            double cel2 = 0;
            double finalfa1 = 0;

            string tmpfah2;

            Console.WriteLine("Geben Sie ihre Grad anzahl in Celsius an: \n");

            tmpfah2 = Console.ReadLine();

            cel1 = Convert.ToInt32(tmpfah2);

            cel2 = cel1 * 9/5;
            finalfa1 = cel2 + 32;

            Console.WriteLine("Das Ergebnis: " + finalfa1 + "F");
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


