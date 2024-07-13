
using System;


class Program
{

   static void Main()
    {    

        int M = ReadInt("Введите число M: "); 
        int N = ReadInt("Введите число N: ");

        PrintDigits(M, N);
    }
    static int ReadInt(string msg){
            System.Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
    }
    static void PrintDigits(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        Console.Write(start + " ");
        PrintDigits(start + 1, end);
}
}

