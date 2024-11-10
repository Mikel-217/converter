using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using MAIN;


namespace MEBIBYTE
{
    public class Mebibyte
    {
        public void mebistart()
        {
            Console.WriteLine("-----------------------------------------\n" +
                "Bitte auswäheln: \n" +
                "1 Mebibyte zu Megabyte\n" +
                "2 Megabyte zu Mebibyte\n" +
                "-----------------------------------------\n");
            inputmeb();
        }

        void inputmeb()
        {
            int inp = 0;
            inp = Convert.ToInt32(Console.ReadLine()!);
            switch (inp)
            {
                case 1:
                    meby();
                    break;
                case 2:
                    mebg();
                    break;
                default:
                    break;
            }
        }

        void meby()
        {
            int mbi1 = 0;
            double final = 0;

            Console.WriteLine("Bitte geben Sie Mebibytes an: \n");
            mbi1 = Convert.ToInt32(Console.ReadLine()!);
            final = mbi1 * 1.049;
            Console.WriteLine($"Sind: {final} Megabyte\n");

            startmebi();
        }

        void mebg()
        {
            int mbi = 0;
            double final = 0;
            Console.WriteLine("Bitte geben Sie Mebibytes an: \n");
            mbi = Convert.ToInt32(Console.ReadLine()!);
            final = mbi / 1.049;
            Console.WriteLine($"{mbi} Sind: {final} Mebibyte\n");
            startmebi();
        }

        void startmebi()
        {
            int tmpintmilen = 0;

            Console.WriteLine("-----------------------------------------\n" +
                "1 Hauptmenü \n" +
                "2 Mehr berechnen \n" +
                "-----------------------------------------\n");

            tmpintmilen = Convert.ToInt32(Console.ReadLine()!);

            switch (tmpintmilen)
            {
                case 1:
                    maininout pr = new maininout();
                    pr.mainout();
                    break;
                case 2:
                    mebistart();
                    break;
                default:
                    break;
            }
        }
    }
}