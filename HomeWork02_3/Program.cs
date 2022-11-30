using System;


namespace HomeWork02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter x array (" + i + ") element :");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thank you_______________");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter y array (" + i + ") element :");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Task 261
            Console.WriteLine("TASK 261______________________");
            int sum_261x = 0;
            int sum_261y = 0;
            for (int i = 0; i < n; i++)
            {
                sum_261x += x[i];

            }
            for (int i = 0; i < n; i++)
            {
                sum_261y += y[i];
            }

            Console.WriteLine((float)sum_261x/n*sum_261y/n);

            // Task 262
            Console.WriteLine("TASK 262______________________");
            int sum_262x = 0;
            int sum_262y = 0;
            for (int i = 0; i < n; i++)
            {
                sum_262x += x[i] * x[i];

            }
            for (int i = 0; i < n; i++)
            {
                sum_262y += y[i] * y[i];
            }

            Console.WriteLine((float)Math.Sqrt(sum_262x / n) + Math.Sqrt(sum_262y / n));

            // Task 263
            Console.WriteLine("TASK 263______________________");
            int sum_263x = 0;
            int sum_263y = 0;
            for (int i = 0; i < n; i++)
            {
                sum_263x += x[i];

            }
            for (int i = 0; i < n; i++)
            {
                sum_263y *= y[i];
            }

            Console.WriteLine((float)sum_263x/sum_263y);

            // Task 265
            Console.WriteLine("TASK 265______________________");
            int sum_265x = 0;
            int sum_265y = 0;
            for (int i = 0; i < n; i++)
            {
                sum_265x += x[i];

            }
            for (int i = 0; i < n; i++)
            {
                sum_265y *= y[i];
            }

            Console.WriteLine((float)sum_265x / sum_265y);


           
        }
    }
}
