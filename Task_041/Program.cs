// Task_041
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
int[] NewArray()
{
    Console.WriteLine("Введите кол-во элементов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите числа: ");
    int[] a = new int[n];
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a;
}
void CreateArray()
{
    int[] a = NewArray();
    int count = 0;
    foreach (int i in a)
        if (i > 0)
            count++;
    string x = string.Join(", ", a);
    Console.WriteLine(x);
    Console.WriteLine($"Количество положительных чисел равно: {count}");
}
CreateArray();