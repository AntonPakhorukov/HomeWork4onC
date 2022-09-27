/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Дополнительная задача (31): Напишите программу, которая задаёт массив из 10 элементов, 
которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них
[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
[-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
[-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7
*/
Console.Clear();
Console.Write("Введите номер задачи: ");
int task = Convert.ToInt32(Console.ReadLine());

if (task == 25)
{
    Task25();
}
else if (task == 27)
{
    Task27();
}
else if (task == 29)
{
    Task29();
}
else if (task == 31)
{
    Task31();

}

void Task25()
{
    /*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
    */
    Console.Write("Введите первое число: ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int second = Convert.ToInt32(Console.ReadLine());
    if (second < 0) second = -second;
    int Pow(int first, int second)
    {
        int result = 1;
        for (int i = 0; i < second; i++)
        {
            result = result * first;
        }
        return result;
    }
    Console.WriteLine(Pow(first, second));

}

void Task27()
{
    /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
    Console.Write("Введите число: ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    if (numbers < 0) numbers = -numbers;
    Console.WriteLine("Каким методом хотите решить (1,2)? ");
    int method = Convert.ToInt32(Console.ReadLine());
    if (method == 1)
    {
        Method1();
    }
    else if (method == 2)
    {
        Method2();
    }
    void Method1()
    {
        String values = String.Join("", numbers);
        int Count(String values)
        {
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                count++;
            }
            return count;
        }
        int ArrayDigital = Count(values);
        int[] array = new int[ArrayDigital];
        for (int i = 0; i < ArrayDigital; i++)
        {
            String str = String.Join("", values[i]);
            array[i] = int.Parse(str);
        }
        int SumNumbers(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i];
            }
            return result;
        }
        Console.WriteLine(SumNumbers(array));
    }

    void Method2()
    {
        int NumberValue(int numbers)
        {
            int count = 0;
            int index = 1;
            while (numbers / index > 0)
            {
                count++;
                index = index * 10;
            }
            return count;
        }
        int value = NumberValue(numbers);
        int SumValue(int numbers, int value)
        {
            int result = 0;
            int index = 0;
            int y = 1;
            while (index < value)
            {
                result = result + ((numbers / y) % 10);
                y = y * 10;
                index++;
            }
            return result;
        }
        int result = SumValue(numbers, value);
        Console.WriteLine(result);
    }
}

void Task29()
{
    /*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
    Console.Write("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }
}

void Task31()
{
    /*Дополнительная задача (31): Напишите программу, которая задаёт массив из 10 элементов, 
которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них
[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
[-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
[-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7*/

    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(array[i] + " ");
    }
    int MaxFind(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }
    Console.WriteLine();
    Console.WriteLine(MaxFind(array));
}



