namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int s = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Веедите элемент {i+1}");
                array[i] = Convert.ToInt32(Console.ReadLine ());
                s += array[i];
            }
            Console.WriteLine($"Среднее арифметическое равно {((double)s)/n}");
        }
    }
}