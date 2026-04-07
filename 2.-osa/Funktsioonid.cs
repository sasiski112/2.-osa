using System;
using System.Linq;

namespace _2._osa
{
    internal class Funktsioonid
    {
        // 1. Juku
        public static void Juku(string nimi)
        {
            Console.WriteLine("Kirjuta oma nimi: ");
            nimi = Console.ReadLine();

            int vanus = 0;
            string pilet = "";

            if (nimi.ToLower().Trim() == "juku")
            {
                while (true)
                {
                    Console.Write("Kui vana Juku on?: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out vanus) && vanus > 0 && vanus < 100)
                        break;

                    Console.WriteLine("Vanus peab olema 1–99!");
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
                try
                {
                    Console.Write("Sisesta esimese inimese nimi: ");
                    nimi1 = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nimi1))
                        break;

                    Console.WriteLine("Nimi ei tohi olla tühi ega sisaldada numbreid!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Sisesta teise inimese nimi: ");
                    nimi2 = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nimi2))
                        break;

                    Console.WriteLine("Nimi ei tohi olla tühi ega sisaldada numbreid!");
                }
                catch
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }

            Console.WriteLine($"Täna on pinginaabrid {nimi1} ja {nimi2}.");
        }

        // 3. Remont
        public static void remond()
        {
            int p1 = 0, p2 = 0;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pikkus1: ");
                    if (!int.TryParse(Console.ReadLine(), out p1) || p1 <= 0)
                        throw new Exception();

                    Console.Write("Sisesta pikkus2: ");
                    if (!int.TryParse(Console.ReadLine(), out p2) || p2 <= 0)
                        throw new Exception();

                    break;
                }
                catch
                {
                    Console.WriteLine("Sisesta positiivsed täisarvud!");
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
                    if (!int.TryParse(Console.ReadLine(), out pind) || pind <= 0)
                        throw new Exception();

                    break;
                }
                catch
                {
                    Console.WriteLine("Sisesta positiivne arv!");
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
                    if (!int.TryParse(Console.ReadLine(), out t))
                        throw new Exception();

                    break;
                }
                catch
                {
                    Console.WriteLine("Sisesta korrektne arv!");
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
                    if (!int.TryParse(Console.ReadLine(), out pikk) || pikk <= 0)
                        throw new Exception();
                    break;
                }
                catch
                {
                    Console.WriteLine("Sisesta positiivne arv!");
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
            string sugu;

            while (true)
            {
                Console.Write("Sisesta sugu (mees/naine): ");
                sugu = Console.ReadLine()?.ToLower().Trim();

                if (sugu == "mees" || sugu == "naine")
                    break;

                Console.WriteLine("Vale sisend!");
            }

            int pikkus;

            while (true)
            {
                try
                {
                    Console.Write("Sisesta pikkus: ");
                    if (!int.TryParse(Console.ReadLine(), out pikkus) || pikkus <= 0)
                        throw new Exception();

                    break;
                }
                catch
                {
                    Console.WriteLine("Sisesta korrektne arv!");
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
            else
            {
                if (pikkus <= 130)
                    Console.WriteLine("Sa oled lühike naine");
                else if (pikkus <= 170)
                    Console.WriteLine("Sa oled keskmine naine");
                else
                    Console.WriteLine("Sa oled pikk naine");
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
                vastus = Console.ReadLine()?.ToLower().Trim();

                if (vastus == "jah")
                {
                    summa += 1.20;
                    break;
                }
                else if (vastus == "ei")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ainult jah või ei!");
                }
            }

            while (true)
            {
                Console.Write("Kas soovid saia? (jah/ei): ");
                vastus = Console.ReadLine()?.ToLower().Trim();

                if (vastus == "jah")
                {
                    summa += 0.80;
                    break;
                }
                else if (vastus == "ei")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ainult jah või ei!");
                }
            }

            while (true)
            {
                Console.Write("Kas soovid leiba? (jah/ei): ");
                vastus = Console.ReadLine()?.ToLower().Trim();

                if (vastus == "jah")
                {
                    summa += 1.50;
                    break;
                }
                else if (vastus == "ei")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ainult jah või ei!");
                }
            }

            Console.WriteLine($"Kokku: {summa:F2} eurot");
        }
    }
}
