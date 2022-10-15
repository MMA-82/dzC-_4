int[] array = new int[20];
Console.Write("Массив трехзначных чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int chet = 0;
int nechet = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 ==0) chet++;
    else nechet++;
}
Console.WriteLine("Количество четных чисел в массиве: " + chet);
Console.WriteLine("Количество нечетных чисел в массиве: " + nechet);