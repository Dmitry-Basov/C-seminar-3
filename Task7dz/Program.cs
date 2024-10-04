// Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.



int[] array = new int[] { 1, 2, 8, 4, 5, 17, 7, 8, 3, 10 };

int i = 0;
double sum = 0;

while(i < array.Length)
{
    sum = sum + array[i];
    i++;
}
double result = sum / array.Length;
Console.Write(result + " ");