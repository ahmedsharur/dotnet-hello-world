using System;

namespace dotnet_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Object [] array = {10, 20, 30, 40};
            int [] arr = {3, 3, 5, -6, 8};
            Console.WriteLine("Hello World!");
            Console.WriteLine(loveFunc(3,2));
            Console.WriteLine(loveFunc(2,2));
            Console.WriteLine(Check(array, 10));
            Console.WriteLine(PositiveSum(arr));

        }
        public static bool loveFunc(int flower1, int flower2)
    { 
    
      return flower1 % 2 != flower2 % 2;
    }
  public static bool Check(object[] a, object x)
    {
    return Array.IndexOf(a, x) != -1;
  }
   
  public static int PositiveSum(int[] arr)
  {
            int Sum = 0;
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] > 0)
                {
                    Sum = Sum + arr[index];
                }
            }
            return Sum;
}
    }
}




    
