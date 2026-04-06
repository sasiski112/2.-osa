using System;
using System.Linq;

namespace _2._osa
{
    internal class Funktsioonid
    {
        // 1. Juku
        public static void Juku(string nimi)
        {
            int vanus = 0;
            string pilet = "";

            if (nimi.ToLower() == "juku")
            {
                while (true)
                {
                    Console.Write("Kui vana Juku on?: ");

                    if (int.TryParse(Console.ReadLine(), out vanus))
                    {
                        if (vanus > 0 && vanus < 100)
                            break;
                        else
                            Console.WriteLine("Vanus peab olema 1–99!");
                    }
                    else
                    {
                        Console.WriteLine("Vigane sisend!");
                    }
                }

                if (vanus < 6)
                    pilet = "Tasuta pilet";
                else if (vanus < 14)
                    pilet = "Lapsepilet";
                else if (vanus < 65)
                    pilet = "Täiskasvanu pilet";
                else
                    pilet = "Sooduspilet";

                Console.WriteLine($"Juku on {vanus} aastat vana. {pilet}");
            }
            else
            {
                Console.WriteLine("Ei lähe kinno");
            }
        }

        // 2. Pinginaabrid
        public static void pinginab()
        {
            string nimi1 = "";
            string nimi2 = "";

            while (true)
            {
                Console.Write("Sisesta esimese inimese nimi: ");
                nimi1 = Console.ReadLine();

                if (nimi1 != "" && !nimi1.Any(char.IsDigit))
                    break;

                Console.WriteLine("Nimi ei tohi sisaldada numbreid!");
            }

            while (true)
            {
                Console.Write("Sisesta teise inimese nimi: ");
                nimi2 = Console.ReadLine();

                if (nimi2 != "" && !nimi2.Any(char.IsDigit))
                    break;

                Console.WriteLine("Nimi ei tohi sisaldada numbreid!");
            }

            Console.WriteLine($"Täna on pinginaabrid {nimi1} ja {nimi2}.");
        }

        // 3. Remont (pindala)
        public static void remond()
        {
            int p1 = 0, p2 = 0;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pikkus1: ");
                    p1 = int.Parse(Console.ReadLine());

                    Console.Write("Sisesta pikkus2: ");
                    p2 = int.Parse(Console.ReadLine());

                    if (p1 > 0 && p2 > 0)
                        break;
                    else
                        Console.WriteLine("Peavad olema positiivsed arvud!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            Console.WriteLine($"Pindala: {p1 * p2}");
        }

        // 4. Remondi hind
        public static void remondihind()
        {
            int pind = 0;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pindala: ");
                    pind = int.Parse(Console.ReadLine());

                    if (pind > 0)
                        break;
                    else
                        Console.WriteLine("Peab olema positiivne!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            Console.WriteLine($"Hind: {pind * 15} eurot");
        }

        // 5. Temperatuur
        public static void temp()
        {
            int t;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta temperatuur: ");
                    t = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            if (t >= 18)
                Console.WriteLine("Temperatuur on vähemalt 18 kraadi");
            else
                Console.WriteLine("Temperatuur on alla 18 kraadi");
        }

        // 6. Pikkus
        public static void pikkus()
        {
            int pikk;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pikkus: ");
                    pikk = int.Parse(Console.ReadLine());

                    if (pikk > 0)
                        break;
                    else
                        Console.WriteLine("Peab olema positiivne!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            if (pikk <= 140)
                Console.WriteLine("Sa oled lühike");
            else if (pikk <= 185)
                Console.WriteLine("Sa oled keskmine");
            else
                Console.WriteLine("Sa oled pikk");
        }

        // 7. Pikkus ja sugu
        public static void piksu()
        {
            Console.Write("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();

            int pikkus;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pikkus: ");
                    pikkus = int.Parse(Console.ReadLine());

                    if (pikkus > 0)
                        break;
                    else
                        Console.WriteLine("Peab olema positiivne!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            if (sugu == "mees")
            {
                if (pikkus < 140)
                    Console.WriteLine("Sa oled lühike mees");
                else if (pikkus <= 185)
                    Console.WriteLine("Sa oled keskmine mees");
                else
                    Console.WriteLine("Sa oled pikk mees");
            }
            else if (sugu == "naine")
            {
                if (pikkus <= 130)
                    Console.WriteLine("Sa oled lühike naine");
                else if (pikkus <= 170)
                    Console.WriteLine("Sa oled keskmine naine");
                else
                    Console.WriteLine("Sa oled pikk naine");
            }
            else
            {
                Console.WriteLine("Tundmatu sugu");
            }
        }

        // 8. Ostukorv
        public static void ostukorv()
        {
            double summa = 0;
            string vastus;

            while (true)
            {
                Console.Write("Kas soovid piima? (jah/ei): ");
                vastus = Console.ReadLine().ToLower();

                if (vastus == "jah") { summa += 1.20; break; }
                else if (vastus == "ei") break;
                else Console.WriteLine("Ainult jah või ei!");
            }

            while (true)
            {
                Console.Write("Kas soovid saia? (jah/ei): ");
                vastus = Console.ReadLine().ToLower();

                if (vastus == "jah") { summa += 0.80; break; }
                else if (vastus == "ei") break;
                else Console.WriteLine("Ainult jah või ei!");
            }

            while (true)
            {
                Console.Write("Kas soovid leiba? (jah/ei): ");
                vastus = Console.ReadLine().ToLower();

                if (vastus == "jah") { summa += 1.50; break; }
                else if (vastus == "ei") break;
                else Console.WriteLine("Ainult jah või ei!");
            }

            Console.WriteLine($"Kokku: {summa:F2} eurot");
        }
    }
}
