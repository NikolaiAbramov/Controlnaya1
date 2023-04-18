Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
string[] arr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    arr[i] = Console.ReadLine()!;
}
Console.WriteLine($"Начальный массив: [{string.Join(", ", arr)}] \t");
int count = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i].Length <= 3)
    {
        count++;
    }
}
string[] newArr = new string[count];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i].Length <= 3)
    {
        newArr[j] = arr[i];
        j++;
    }
}
Console.WriteLine($"Новый массив с длинной строк <= 3: [{string.Join(", ", newArr)}] \t");