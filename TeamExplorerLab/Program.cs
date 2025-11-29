using System;

namespace TeamExplorerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки (x, y):");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите радиусы окружностей (r1, r2):");
            Console.Write("r1 = ");
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("r2 = ");
            double r2 = Convert.ToDouble(Console.ReadLine());

            // Определяем больший и меньший радиус
            double R = Math.Max(r1, r2);
            double r = Math.Min(r1, r2);

            // Вычисляем расстояние от точки до центра координат
            double d = Math.Sqrt(x * x + y * y);

            if (d > r && d < R)
            {
                Console.WriteLine("Точка находится ВНУТРИ области.");
            }
            else if (d < r || d > R)
            {
                Console.WriteLine("Точка находится ВНЕ области.");
            }
            else
            {
                Console.WriteLine("Точка находится НА ГРАНИЦЕ области.");
            }

            Console.ReadKey();
        }
    }
}