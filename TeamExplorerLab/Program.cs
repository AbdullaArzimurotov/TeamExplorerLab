using System;

namespace TeamExplorerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nuqtaning koordinatalarini kiriting (x, y):");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aylanalar radiuslarini kiriting (r1, r2):");
            Console.Write("r1 = ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2 = ");
            double r2 = Convert.ToDouble(Console.ReadLine());

            // Katta va kichik radiusni aniqlab olamiz
            double R = Math.Max(r1, r2);
            double r = Math.Min(r1, r2);

            // Nuqtaning markazdan masofasini hisoblaymiz
            double d = Math.Sqrt(x * x + y * y);

            if (d > r && d < R)
            {
                Console.WriteLine("Nuqta soha ICHIDA yotadi.");
            }
            else if (d < r || d > R)
            {
                Console.WriteLine("Nuqta soha TASHQARISIDA yotadi.");
            }
            else
            {
                Console.WriteLine("Nuqta soha CHEGARASIDA yotadi.");
            }

            Console.ReadKey();
        }
    }
}