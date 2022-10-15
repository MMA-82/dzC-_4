Console.WriteLine("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[length];
Console.Write("Массив чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
double min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(min > array[i]) min = array[i];
}
Console.Write("Минимальное число массива: " + min);
Console.WriteLine();
double max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
}
Console.Write("Максимальное число массива: " + max);
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным равна: " + (max-min));