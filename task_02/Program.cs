using System;

class Program
{
    static void Main()
    {
        int m =  ReadInt("Задайте значение m: ");
        int n =  ReadInt("Задайте значение n: ");
        

        int answer = AckermannFunction(m, n);
        
  
        Console.WriteLine($"A({m}, {n}) = {answer}");
    }

    static int ReadInt(string msg){
            System.Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            Console.Write("Ошибка! Вы ввели отрицательные числа. Функция только для положительных чисел!");
            throw new Exception();
 
        }
    }
}

