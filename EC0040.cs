using System;
using System.Globalization;

class EC0040
{
    static void Main(String [] args)
    {
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("Introduce un numero: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " , ");
        }

    }
}