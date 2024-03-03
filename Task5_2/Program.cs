namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 15;
            Random random = new Random();
            int[] array = new int[n];
            
            for (int i = 0; i < n; i++)
            {            
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);                
            }                    
            Console.WriteLine();
            int max = array[0];
            int min = array[0];

            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            Console.WriteLine($"Сумма минимального и максимального элемента = {max + min}");
        }
    }
}