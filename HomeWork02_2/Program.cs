using System;

namespace HomeWork02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array size: ");
            int sizeofarray = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[sizeofarray];
            for (int i = 0; i < sizeofarray; i++)
            {
                Console.Write("Enter (" + i + ") element :");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Task 251
            Console.WriteLine("TASK 251______________________");
            int max_251 = a[0];
            for (int i = 1; i < a.Length; i ++)
            {
                if (a[i] > max_251)
                    max_251 = a[i];
            }
            Console.WriteLine(max_251);

            // Task 252
            Console.WriteLine("TASK 252______________________");
            int min_252 = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_252)
                    min_252 = a[i];
            }
            Console.WriteLine(min_252);


            // Task 253
            Console.WriteLine("TASK 253______________________");
            int min_253 = a[0];
            int max_253 = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_253)
                    min_253 = a[i];
                if (a[i] > max_253)
                    max_253 = a[i];
            }
            Console.WriteLine(min_253+max_253);

            // Task 254
            Console.WriteLine("TASK 254______________________");
            int min_254 = a[0];
            int max_254 = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_254)
                    min_253 = a[i];
                if (a[i] > max_254)
                    max_254 = a[i];
            }
            Console.WriteLine(min_254 * max_254);

            // Task 255
            Console.WriteLine("TASK 255______________________");
            int max_255 = a[0];
            int consol_255 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max_255)
                {
                    max_255 = a[i];
                    consol_255 = i;
                }
            }
            Console.WriteLine(max_255 + consol_255);

            // Task 256
            Console.WriteLine("TASK 256______________________");
            int min_256 = a[0];
            int consol_256 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_256)
                {
                    min_256 = a[i];
                    consol_256 = i;
                }
            }
            Console.WriteLine(min_256 + consol_256);

            // Task 257
            Console.WriteLine("TASK 257______________________");
            int max_257 = a[0];
            int consol_257 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max_257 && a[i] != max_257)
                {
                    max_257 = a[i];
                    consol_257 = i;
                }
            }
            Console.WriteLine(consol_257);

            // Task 257
            Console.WriteLine("TASK 257______________________");
            int max_258 = a[0];
            int consol_258 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] >= max_258)
                {
                    max_258 = a[i];
                    consol_258 = i;
                }
            }
            Console.WriteLine(consol_258);

            // Task 259
            Console.WriteLine("TASK 259______________________");
            int min_259 = a[0];
            int consol_259 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_259 && a[i] != min_259)
                {
                    min_259 = a[i];
                    consol_259 = i;
                }
            }
            Console.WriteLine(consol_259);

            // Task 260
            Console.WriteLine("TASK 260______________________");
            int min_260 = a[0];
            int consol_260 = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] <= min_260)
                {
                    min_260 = a[i];
                    consol_260 = i;
                }
            }
            Console.WriteLine(consol_260);
        }
    }
}
