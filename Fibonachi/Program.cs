namespace ConsoleApp1
{
    internal class Program
    {
        static long Fib(int n)
        {
            if ((n == 0) || (n == 1))
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        static long Fib2(int n)
        {
            if (n == 0) return 0;
            int prev = 0;
            int next = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число для рекурсивного метода: ");
            int userNumForFib = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число для не рекурсивного метода: ");
            int userNumForFib2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fib(userNumForFib));
            Console.WriteLine(Fib2(userNumForFib2));

        }
    }
}
