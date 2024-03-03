namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, res, sum_i0, sum = 0;
            Console.WriteLine("Введите размерность");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент ({0},{1}) ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());                   
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            res = 1;
            sum_i0 = 0;
            
            for (int j = 0; j < n; j++) // сумма элементов 1 строки
            {
                sum_i0 += array[0, j];
            }            

            for (int i = 1; i < n; i++) // суммы по строкам
            {
                sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += array[i, j];                   
                }
                if (sum != sum_i0)
                {
                    res = 0; break;
                }
            }           

            if (res == 1) // суммы по столбцам
            {
                for(int j = 0; j < n; j++)
                {
                    sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += array[i, j];                      
                    }
                    if (sum != sum_i0)
                        {
                            res = 0; break;
                        }
                }
            }

            if (res == 1) // сумма элементов главной диагонали
            {
                sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += array[i, i];                    
                }
                if (sum != sum_i0)
                {
                    res = 0;
                }

            }

            if (res == 1) // сумма элементов побочной диагонали
            {
                sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += array[i, n - i - 1];                    
                }
                if (sum != sum_i0)
                {
                    res = 0;
                }
            }
            if (res == 1)
                {
                    Console.WriteLine("Это магический квадрат. Сумма: {0}", sum);
                    return;
                }
            Console.WriteLine("Не получился магический квадрат :(");
        }
    }
}