using System;

namespace Act3
{
    class Program
    {
        static int setupTable()
        {
            int tableNum;
            Console.WriteLine("##### Add the number of tables #####");
            tableNum = Convert.ToInt32(Console.ReadLine());
             return tableNum;
        }
        static int setupMul()
        {
            int mul;
            Console.WriteLine("##### Add the number of Multiples #####");
            mul = Convert.ToInt32(Console.ReadLine());
            return mul;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("##### Table Generator #####");

            int num1 = setupTable();
            int num2 = setupMul();

            int[] arr1 = new int[num1 + 1];
            int[] arr2 = new int[num2 + 1];

             for (int i = 1; i < arr1.Length; i++)
             {
                Console.WriteLine("##### Table " + i + " ######");

                 for(int j = 1; j < arr2.Length; j++)
                 {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                 }
                
            }




        }
    }
}
