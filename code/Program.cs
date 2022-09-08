/*
Написать программу,
которая из имеющегося массива строк
формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

string[] CreateTextArray()
{
    Console.WriteLine("Задайте количество элементов в массиве:");
    int size = int.Parse(Console.ReadLine());
    string input = String.Empty;
    string[] textArr = new string[size];
    int i = 0;
    do
    {
        Console.WriteLine($"Введите строку {i + 1}:");
        input = Console.ReadLine();
//        Console.WriteLine(input);
        textArr[i] = input;
        i++;
    }
    while (i < size);
    return textArr;
}

void PrintTextArray(string[] textArr)
{
    for (int i = 0; i < textArr.Length; i++)
        Console.WriteLine(textArr[i]);
}
string[] textArray = CreateTextArray();

Console.WriteLine("Вы создали следующий массив:");

PrintTextArray(textArray);