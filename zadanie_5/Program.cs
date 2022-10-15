int[] array = new int[15];
Console.Write("Массив чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int sumnechet = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] %2 ==1) sumnechet = sumnechet + array[i];
}
Console.WriteLine("Сумма нечетных чисел в массиве: " + sumnechet);

