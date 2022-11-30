using System;

namespace HomeWork02
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

            //// Task 211
            //Console.WriteLine("TASK 211______________________");
            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if ( a[i] > 0)
            //    {
            //        sum += a[i];
            //        count++;
            //    }
            //}
            //Console.WriteLine((float)sum/count);

            //// Task 212
            //Console.WriteLine("TASK 212______________________");

            //int sum_212 = 0;
            //int count_212 = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > 0)
            //    {
            //        sum_212 += a[i] * a[i];
            //        count_212++;
            //    }
            //}
            //Console.WriteLine(Math.Sqrt((float)sum_212 / count_212));

            //// Task 213
            //Console.WriteLine("TASK 213______________________");

            //int sum_213 = 0;
            //int count_213 = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        sum_213 += a[i] * a[i];
            //        count_213++;
            //    }
            //}
            //Console.WriteLine(Math.Sqrt((float)sum_213 / count_213));

            //// Task 214
            //Console.WriteLine("TASK 214______________________");

            //int sum_214 = 0;
            //int count_214 = 0;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        sum_214 += a[i];
            //        count_214++;
            //    }
            //}
            //Console.WriteLine((float)sum_214 / count_214);

            //// Task 215
            //Console.WriteLine("TASK 215______________________");

            //int sum_215 = 0;
            //for (int i = 2; i < a.Length; i += 2)
            //{
            //    sum_215 += a[i];
            //}
            //Console.WriteLine(sum_215);


            //// Task 216
            //Console.WriteLine("TASK 216______________________");
            //int sum_216 = 0;
            //for (int i = 2; i < a.Length; i += 2)
            //{
            //    sum_216 *= a[i];
            //}
            //Console.WriteLine(sum_216);


            //// Task 217
            //Console.WriteLine("TASK 213______________________");
            //int sum_217 = 1;
            //for (int i = 1; i < a.Length; i += 2)
            //{
            //    sum_217 *= a[i] * a[i];
            //}
            //Console.WriteLine(sum_217);

            //// Task 218
            //Console.WriteLine("TASK 218______________________");
            //int sum_218 = 0;
            //for (int i = 1; i < a.Length; i += 2)
            //{
            //    if (a[i] > 0)
            //    {
            //        sum_218 += a[i];
            //    }
            //    else
            //    {
            //        sum_218 += a[i]*-1;
            //    }
            //}
            //Console.WriteLine(sum_218);

            //// Task 225
            //Console.WriteLine("TASK 225______________________");
            //int t = 8;
            //int count_225= 1;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        if (a[i] * -1 < t)
            //            count_225 *= a[i] * -1;
            //    }
            //    else if (a[i] < t )
            //    {
            //        count_225 *= a[i];
            //    }
            //}
            //Console.WriteLine(count_225);
            
        }
    }
}
