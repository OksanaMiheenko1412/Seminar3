// task 22 на вход(число N), на выход(таблица квадратов чисел от 1 до N)

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{i * i}");
