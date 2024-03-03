namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            Random random = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < n - 6; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 5; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }            
        }
    }
}