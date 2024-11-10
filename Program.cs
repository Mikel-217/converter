using System;
using MILEN;
using MILE;
using DOLLAR;
using FAHREN;
using BIT;
using MEBIBYTE;


namespace MAIN {
    
    public class Program {
        public static void Main(string[] args) {
            
            Console.Title = "Umrechner";
            maininout man = new maininout();
            man.mainout();
            
        }
    }
    public class maininout {
        public void mainout() {
            
            Console.WriteLine("-----------------------------------------\n" +
                "Was möchten Sie berechnen/umrechnen?\n" +
                "1 MPh zu KMh\n" +
                "2 Milen zu Kilometer\n" +
                "3 Fahrenheiten zu Celsius\n" +
                "4 Bit zu Bytes\n" +
                "5 Megabyte zu Mebibyte\n" +
                "6 Dollar zu Euro\n" +
                "7 Exit\n" +
                "Schreiben Sie eine Zahl rein um dieses auszuwählen:\n" +
                "-----------------------------------------\n");
            mainput();
        }

        public void mainput() {
            
            int inputt = 0;
            inputt = Convert.ToInt32(Console.ReadLine()!);
            switch (inputt) {
                case 1:
                    Miles startmi = new Miles();
                    startmi.startm();
                    break;
                case 2:
                    Mile startmile = new Mile();
                    startmile.milestart();
                    break;
                case 3:
    	            fahren fah = new fahren();
                    fah.startenfah();
                    break;
                case 4:
                    bitb bit = new bitb();
                    bit.startbit();
                    break;
                case 5:
                    Mebibyte meb = new Mebibyte();
                    meb.mebistart();
                    break;
                case 6:
                    dtoe dollar = new dtoe();
                    dollar.startdoll();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}