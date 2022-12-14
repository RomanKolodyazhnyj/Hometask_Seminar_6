// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите количество M: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int[] array = PrintNumbers(numbers);

int count = GetCount(array);
Console.WriteLine($"Количество чисел больше нуля: {count}");

int[] PrintNumbers(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}