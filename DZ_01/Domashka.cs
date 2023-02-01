namespace DZ_01
{
    internal class Domashka
    {
        static void Main(string[] args)
        {
            //a)
            Console.WriteLine("Введите число и единицы измерения: ");
            int i = Convert.ToInt32(Console.ReadLine());
            string? c = Console.ReadLine();
            Console.WriteLine(i + " " + c);
            Console.WriteLine("Введите два числа: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m + " " + k);

            Console.WriteLine();

            //b)
            Console.WriteLine("Введите a и b: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(a + " " + 1);
            Console.WriteLine(19 + " " + b);

            Console.WriteLine();

            //c)
            Console.WriteLine("Введите x и y: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(x + " " + y);
            Console.WriteLine(5 + " " + y);
        }
    }
}