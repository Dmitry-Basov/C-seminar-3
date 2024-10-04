// Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.

using System.Globalization;
int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int[] array = { 1, 3, 8, 19, 3 };
bool isExistNum = false;

for (int i=0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        isExistNum = true;
        break;
    }
}


// string result = isExistNum ? "Да" : "Нет";
Console.WriteLine(isExistNum ? "Присутствует" : "Не присутствует");
