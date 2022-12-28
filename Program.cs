// Написать программу, которая из имеющегося массива строк сформирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив ввести с клавиатуры или задать на старте выполнения алгоритма.

void FillStartArray(string[] stringArray, int maxLength, out int finalArraySize)
{
    finalArraySize = 0;

    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write("Введите текстовый элемент массива [" + i + "] : ");
        stringArray[i] = Console.ReadLine();

        if (stringArray[i].Length <= maxLength)
            finalArraySize++;
    }
}

string[] MakeResultArray(string[] stringArray, int maxLength, int arraySize)
{
    string[] finalArrayString = new string[arraySize];
    int counter = 0;

    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= maxLength)
        {
            finalArrayString[counter] = stringArray[i];
            counter++;
        }
    }

    return finalArrayString;
}

Console.Clear();
const int maxElementLength = 3; // максимальная длина элементов массива, которые будем выбирать

Console.Write("Какое количество элементов будет в исходном массиве? ");
int numbersN = Convert.ToInt32(Console.ReadLine());

string[] startArray = new string[numbersN];
FillStartArray(     stringArray: startArray,
                    maxLength: maxElementLength,
                    out int finalArraySize
                    );

string[] finalArray = new string[finalArraySize];
finalArray = MakeResultArray(   stringArray: startArray, 
                                maxLength : maxElementLength,
                                arraySize: finalArraySize
                                );    

Console.WriteLine("[" + String.Join(",", startArray) + "] -> [" + String.Join(",", finalArray) + "]");