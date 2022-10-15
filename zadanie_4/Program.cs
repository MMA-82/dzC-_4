int[] array = new int[123];
Console.Write("Массив из 123-х чисел: ");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int result = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] >=10 && array[i] <=99) result++;
}
Console.WriteLine("Количество чисел, удовлетворяющих промежутку [10, 99]: " + result);

