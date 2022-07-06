// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
using static System.Console;

Clear();

WriteLine("Введите числа через пробел: ");
int [] numbers = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(", ",numbers)}] -> {CountNumbersAgainNull(numbers)}");


int [] GetArrayFromString (string arrayStr)
{
    string [] arS=arrayStr.Split(new char[] {' ',',','*'},StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [arS.Length];
    for (int i=0; i<arS.Length; i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}

int CountNumbersAgainNull (int [] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]>0) count = count+1; 
        
    }
    return count;
}
