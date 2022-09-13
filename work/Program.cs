/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20*/

/*int [] array = new int [12];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void ArraySum(int[] ar){
    int sum1 = 0; 
    int sum2 = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i] > 0){
            sum1 += ar[i];
        }

        if(ar[i] < 0){
            sum2 += ar[i];
        }
    }
    Console.WriteLine($"Сумма положительных элементов = {sum1}");
    Console.WriteLine($"Сумма отрицателых элементов = {sum2}");
}

ArraySum (array);*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

/*int [] array = new int [4];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void ArraySort (int [] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] *= -1;
    }
}

ArraySort (array);*/

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/
/*
Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void SearhNumber (int n, int [] ar){
    int help = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i] == n) {
            Console.WriteLine($"Заданое число {n} присутствует в массиве на позиции {i}");
            help += 1;
            break;
        }
    }

    if (help == 0){
            Console.WriteLine($"Заданое число {n} НЕ присутствует в массиве");
    }

    
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

SearhNumber(number, array);*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/
/*
Console.Clear();
int [] array = new int [123];

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-100, 150);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

void ArraySort1(int [] ar){
    int help = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        
        if(ar[i] >= 10 & ar[i] <= 99) {
            //Console.WriteLine($"{ar[i]} ");
            help += 1;
        }
    }
    Console.WriteLine($"Колличество элементов в диапазоне [10; 99] = {help}");
}

ArraySort1 (array);*/




/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


int [] CreateArray (int n, int x, int y){ // n - size;  x - min element; y - max-1 element
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(x, y);
    }
    return array;
}

void PrintArray (int [] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

int [] PairElementArray (int [] ar){
    
    if (ar.Length % 2 == 0){
        int [] pairelementarray = new int [ar.Length/2];
        for (int i = 0; i < ar.Length/2; i++)
        {
            pairelementarray [i] = ar[i] * ar[ar.Length-1-i];
        }
        return pairelementarray;
    }
    else {
        int [] pairelementarray = new int [ar.Length/2+1];
        for (int i = 0; i < ar.Length/2; i++)
        {
            pairelementarray [i] = ar[i] * ar[ar.Length-1-i];
        }
        pairelementarray [ar.Length/2] = ar[ar.Length/2];
        return pairelementarray;
    }
}

Console.Clear();
int [] array7 = CreateArray (11, -10, 11);
PrintArray (array7);
int [] array7_1 = PairElementArray (array7);
PrintArray (array7_1 );