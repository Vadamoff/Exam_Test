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

//Метод создаёт массив.
//Количество элементов и сами элементы задаются пользователем.
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
//        Console.WriteLine("Вы ввели:");
//        Console.WriteLine(input);
        textArr[i] = input;
        i++;
    }
    while (i < size);
    return textArr;
}

//Метод выводит массив.
void PrintTextArray(string[] textArr)
{
    for (int i = 0; i < textArr.Length; i++)
        Console.Write($"{textArr[i]}    ");
}

//Метод подсчитывает количество элементов массива,
//длина которых не превышает 3 символов.
int CalcLengthArray(string[] textArr)
{
    int count = 0;
    for(int i = 0; i < textArr.Length; i++)
    {
        if(textArr[i].ToCharArray().Length <= 3)
            count++;
    }
//    Console.WriteLine("Количество элементов массива, длина которых не превышает 3 символов:");
//    Console.WriteLine(count);
    return count;
}

//Метод добавляет в новый массив
//все элементы входящего массива,
//длина которых не превышает 3 символов.
string[] RemakeArray(string[] textArr, int size)
{
    string[] newTextArr = new string[size];
    int j = 0;
    for(int i = 0; i < textArr.Length; i++)
    {
        if(textArr[i].ToCharArray().Length <= 3)
        {
            newTextArr[j] = textArr[i];
            j++;
        }
    }
    return newTextArr;
}

string[] textArray = CreateTextArray();

//Console.WriteLine("Вы создали следующий массив:");

//PrintTextArray(textArray);

int arraySize = CalcLengthArray(textArray);

string[] newTextArray = RemakeArray(textArray, arraySize);

Console.WriteLine("Новый массив из строк, длина элементов которого не превышает 3 символов:");

PrintTextArray(newTextArray);