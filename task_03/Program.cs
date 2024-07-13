using System;

class Program
{
    static void Main()

    {
        int size = ReadInt("Введите размер массива случ чисел: ");
        int[] array = FulfillRandomArray(size); 
        Console.WriteLine($"Исходный случайный массив из {size} элементов: ");
        PrintArray(array, 0);
        Console.WriteLine("\nРеверс этого массива: ");
        PrintReverceArray(array, array.Length - 1);
    }

    static int[] FulfillRandomArray(int size){
    Random random = new Random();
    int[] array = new int[size];
    for(int i =0; i<size; i++){
        array[i]=random.Next(1,1000);
    }

    return array;
   

}


    static int ReadInt(string msg){
            System.Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
    }

    static void PrintArray(int[] arr, int index)

    {
        if (index > arr.Length -1) return;
     
        Console.Write(arr[index] + " ");
        PrintArray(arr, index+1); 
    }

    static void PrintReverceArray(int[] arr, int index)
    {
        if (index < 0) return;
    
        Console.Write(arr[index] + " ");
        PrintReverceArray(arr, index - 1); 
    }
}




