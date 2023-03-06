using System;

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1 (3.1)
        double x, y, A, B;
        Console.Write("ЗАВДАННЯ 3.1\nx = ");
        x = double.Parse(Console.ReadLine());
        A = 1 / x + 4;
        if (x < 1)
            B = 0.65 * x + 8;
        else if (x >= 5)
            B = Math.Sqrt(1 + Math.Sqrt(x));
        else
            B = Math.Atan((x + 6.1) / 2) + Math.Exp(x);
        y = A - B;
        Console.WriteLine("y = " + y);

        // Завдання 2 (4.2)
        double xp, xk, dx;
        Console.Write("\nЗАВДАННЯ 4.2\nxp = ");
        xp = double.Parse(Console.ReadLine());
        Console.Write("xk = ");
        xk = double.Parse(Console.ReadLine());
        Console.Write("dx = ");
        dx = double.Parse(Console.ReadLine());
        Console.WriteLine("---------------------------");
        Console.WriteLine("|    x    |     y     |");
        Console.WriteLine("---------------------------");
        for (double i = xp; i <= xk; i += dx)
        {
            A = 1 / i + 4;
            if (i < 1)
                B = 0.65 * i + 8;
            else if (i >= 5)
                B = Math.Sqrt(1 + Math.Sqrt(i));
            else
                B = Math.Atan((i + 6.1) / 2) + Math.Exp(i);
            y = A - B;
            Console.WriteLine("|{0,9:F2}|{1,11:F3}|", i, y);
        }
        Console.WriteLine("---------------------------");

        // Завдання 3 (4.1)
        int k, N;
        double S;

        Console.Write("\nЗАВДАННЯ 4.1\nN = ");
        N = int.Parse(Console.ReadLine());

        S = 0;
        k = N;
        while (k <= 19)
        {
            S += Math.Sqrt(Math.Pow(Math.Sin(1.0 * k), 2) + Math.Pow(Math.Cos(1.0 * (N / k)), 2));
            k++;
        }
        Console.WriteLine(S);

        S = 0;
        k = N;
        do
        {
            S += Math.Sqrt(Math.Pow(Math.Sin(1.0 * k), 2) + Math.Pow(Math.Cos(1.0 * (N / k)), 2));
            k++;
        } while (k <= 19);
        Console.WriteLine(S);

        S = 0;
        for (k = N; k <= 19; k++)
        {
            S += Math.Sqrt(Math.Pow(Math.Sin(1.0 * k), 2) + Math.Pow(Math.Cos(1.0 * (N / k)), 2));
        }
        Console.WriteLine(S);

        S = 0;
        for (k = 19; k >= N; k--)
        {
            S += Math.Sqrt(Math.Pow(Math.Sin(1.0 * k), 2) + Math.Pow(Math.Cos(1.0 * (N / k)), 2));
        }
        Console.WriteLine(S);
    }
}
