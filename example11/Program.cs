// A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.
// A2.5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.
// A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
// A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.
// A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа.
// A2.9. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.

Console.WriteLine("Введите трехзначное число");
int arr = Convert.ToString(Console.ReadLine());
Console.WriteLine(num[0]);
// int position = i;
// for (int i = 0; i < num.Length; i++)
//         int temporary = num[i]; // производится замена элемента
//         num[i] = num[position];
//         num[position] = temporary;
// Console.Write(num);

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)// ищет максимальный элемент
    {
        if (array[j] < array[minPosition]) 
        {
            minPosition = j;
        }
    }
        int temporary = array[i]; // производится замена элемента
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);