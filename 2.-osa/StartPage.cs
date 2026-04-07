using _3._osa;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace _2._osa
{
    internal class StartPage
    {
        public static void Main()
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("\n--- MENÜÜ ---");
                Console.WriteLine("1 - Juku kinopilet");
                Console.WriteLine("2 - Pinginaabrid");
                Console.WriteLine("3 - Remont (pindala)");
                Console.WriteLine("4 - Remondi hind");
                Console.WriteLine("5 - Temperatuur");
                Console.WriteLine("6 - Pikkuse analüüs");
                Console.WriteLine("7 - Pikkus ja sugu");
                Console.WriteLine("8 - Ostukorv");
                Console.WriteLine("0 - Välju");

                Console.Write("Vali: ");
                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Console.Clear();
                        Funktsioonid.Juku("Juku");
                        break;

                    case "2":
                        Console.Clear();
                        Funktsioonid.pinginab();
                        break;

                    case "3":
                        Console.Clear();
                        Funktsioonid.remond();
                        break;

                    case "4":
                        Console.Clear();
                        Funktsioonid.remondihind();
                        break;

                    case "5":
                        Console.Clear();
                        Funktsioonid.temp();
                        break;

                    case "6":
                        Console.Clear();
                        Funktsioonid.pikkus();
                        break;

                    case "7":
                        Console.Clear();
                        Funktsioonid.piksu();
                        break;

                    case "8":
                        Console.Clear();
                        Funktsioonid.ostukorv();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Head aega!");
                        a = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Vale valik!");
                        a = false;
                        break;  
                }
            }
        }
    }
}
//    internal class StartPage
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("\n--- Menu ---");
//                Console.WriteLine("1 - Ruudud");
//                Console.WriteLine("2 - Käivita Analüüs");
//                Console.WriteLine("3 - Inimesed");
//                Console.WriteLine("4 - Märksõna");
//                Console.WriteLine("5 - Arva Arv");
//                Console.WriteLine("6 - Suurim Arv");
//                Console.WriteLine("7 - Korrutustabel");
//                Console.WriteLine("8 - Tudengid");
//                Console.WriteLine("9 - ArvRud");
//                Console.WriteLine("10 - PositivneNegativne");
//                Console.WriteLine("11 - Keskmine");
//                Console.WriteLine("12 - Kõige Suurem");
//                Console.WriteLine("13 - Paari Loendused");
//                Console.WriteLine("0 - Välju");
//                Console.Write("Vali tegevus: ");

//                string valik = Console.ReadLine();

//                switch (valik)
//                {
//                    case "1": Funktsioon.Ruudud(); break;
//                    case "2": Funktsioon.KäivitaAnalüüs(); break;
//                    case "3": Funktsioon.Inimesed(); break;
//                    case "4": Funktsioon.Märksõna(); break;
//                    case "5": Funktsioon.ArvaArv(); break;
//                    case "6": Funktsioon.SuurimArv(); break;
//                    case "7": Funktsioon.Korrutustabel(); break;
//                    case "8": Funktsioon.Tudengid(); break;
//                    case "9": Funktsioon.ArvRud(); break;
//                    case "10": Funktsioon.PositivneNegativne(); break;
//                    case "11": Funktsioon.Keskmine(); break;
//                    case "12": Funktsioon.KõigeSuurem(); break;
//                    case "13": Funktsioon.PaariLoendused(); break;
//                    case "0":
//                        Console.WriteLine("Programmi lõpetamine...");
//                        return;
//                    default:
//                        Console.WriteLine("Vale valik! Proovi uuesti.");
//                        break;
//                }

//                Console.WriteLine("\n--- Tegevus lõpetatud ---\n");
//            }
//        }
//    }
//}
