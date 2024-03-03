namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            Random random = new Random();
            int[] array = new int[n];
            int kol = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);                
                Console.WriteLine("{0,2}: {1,3}",i, array[i]);
                if (i % 2 == 0 && array[i] % 2 > 0 && array[i] > 0)
                   kol++;
            }
            Console.WriteLine($"Количество нечетных положительных элементов на четных местах: {kol}");
        }
    }
}