using System;

namespace problema1
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Suma elementelor unui vector");

            Console.WriteLine("cate elemente are vectorul:  ");


            int n = Convert.ToInt32(Console.ReadLine());

            int[] array =  new int[n];

            

            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"elementul {i} este: ");
                array[i]=Convert.ToInt32(Console.ReadLine());

            }

            int s = 0;

            Console.WriteLine( sum(array,n-1,s));

            

        }
        public static int sum(int[] vector,int n,int s)
        {
            //int s=0;
           
            if (n == 0)
                return vector[n];
            else
            {
              
                return  vector[n]+ sum(vector, n - 1, vector[n]);

            }

        }
    }
}
