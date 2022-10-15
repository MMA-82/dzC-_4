int[] array = new int[12];
Console.Write("Массив чисел из 12-ти элементов: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int sum = 0;
int antisum = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) sum = sum + array[i];
    else antisum = antisum + array[i];
}
Console.Write("Сумма всех положительных чисел равна: " + sum);
Console.WriteLine();
Console.Write("Сумма всех отрицательных чисел равна: " + antisum);