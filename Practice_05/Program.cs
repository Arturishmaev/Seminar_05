//Типы методов
//1) ничего не принимает и ничего не возвращает

void HelloWorld()
{
    System.Console.WriteLine("Hello World!");
}

HelloWorld();

//2) Принимает значение, но ничего не возвращает.

void HelloWorld(string name)
{
    System.Console.WriteLine("Hello" + name);
}
string q = "Bob";

HelloWorld(q);

//3) Принимает и возвращает значение.

int MaxNum(int x, int y)
{
    if (x > y)
    {
        return x;
    }
    else
    {
        return y;
    }
}
int x = 5;
int y = 10;
int maxn = MaxNum(x, y);
System.Console.WriteLine($"{maxn} - больше ");


int a = 15;
int b = 10;
int max = MaxNum(a, b);
System.Console.WriteLine($"{max} - больше ");

//Задача 31: Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9, 9].Найдите сумму отрицательных и положительных элементов массива.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        System.Console.Write($" [{arr[i]}] ");
    }

}

void Summ(int[] array)
{
    int i = 0;
    int minus = 0;
    int plus = 0;

    while (i < array.Length)
    {
        if (array[i] < 0)
        {
            minus = minus + array[i];
            i++;
        }
        else
        {
            plus = plus + array[i];
            i++;
        }
    }
    System.Console.WriteLine($"Сумма отрицательных элементов массива : {minus}");
    System.Console.WriteLine($"Сумма положительных элементов массива : {plus}");


}

int[] array = new int[12];

FillArray(array);
PrintArray(array);
Summ(array);


//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        System.Console.Write($" [{arr[i]}] ");
    }

}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = new int[4];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Reverse(array);
PrintArray(array);


//Задача 33: Задайте массив. Напишите программу. которая определяет, присутствует ли заданное число в массиве.
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }

}

void Comparsion(int[] array)
{
    System.Console.WriteLine("Введите Ваше число для проверки совпадения в массиве : ");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length ; i++)
    {
        if (array[i] == num)
        {
            System.Console.WriteLine($"Введеное число есть в массиве под индексом: {i} ");
        }
        else 
        {
            System.Console.WriteLine("Совпадений не найдено");
        }
    }

}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Comparsion(array);



//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 124);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {

        System.Console.Write($" [{array[i]}] ");
    }

}

void ElementsCount(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 10 && array[i] < 100)
        {
            System.Console.Write($" Количество элементов в отрезке [10, 99] = {array[i]} ");
            break;
        }
    }

}

int[] array = new int[123];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ElementsCount(array);




//Задача: Найдите произведение пар чисел в одномерном массиве.Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.






