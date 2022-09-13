int [] CreateArray (int n, int x, int y){ // n - size;  x - min element; y - max+1 element
    int [] array = new int [n];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(x, y);
    }
    return array;
}

void PrintArray (int[] ar){
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
    Console.WriteLine();
}

int MaxElementArray (int[] ar){
    int max = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (max < ar[i]){
            max = ar[i];
        }
    }
    return max;
}

int MinElementArray (int[] ar){
    int min = ar[0];
    for (int i = 0; i < ar.Length; i++)
    {
        if (min > ar[i]){
            min = ar[i];
        }
    }
    return min;
}

int Metod34 (int[] ar){
    int help = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if(ar[i] % 2 == 0){
            help +=1;
        }
    }
    return help;
}

int Metod36 (int[] ar){
    int sum = 0;
    for (int i = 1; i < ar.Length; i +=2 )
    {
        sum += ar[i];
    }
    return sum;
}

/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();

Console.WriteLine("Задача 34");
int [] array1 = CreateArray(20, 100, 1000);
PrintArray (array1);
int count = Metod34(array1);
Console.WriteLine($"количество чётных чисел в массиве = {count}");
Console.WriteLine();


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Задача 36");
int [] array2 = CreateArray(5, -50, 51);
PrintArray (array2);
int sum36 = Metod36(array2);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum36}");
Console.WriteLine();




/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("задача 38");
int [] array38 = CreateArray(20, 0, 100);
PrintArray(array38);
int max = MaxElementArray(array38);
int min = MinElementArray(array38);
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {max - min}");

