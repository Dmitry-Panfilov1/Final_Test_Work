Console.WriteLine("enter array length");
int arrayLength = int.Parse(Console.ReadLine()!);

string[] stringArray = CreateArray(arrayLength);

PrintArray(stringArray);

int lengthBorder = 3;

string[] newStringArray = LineLengthLimit(stringArray, lengthBorder);

PrintArray(newStringArray);

string[] LineLengthLimit(string[] array, int border)
{
    int index = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < border + 1)
        {
            index++;
        }
    }

    string[] newArray = new string[index];

    int newArrayIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < border + 1)
        {
            newArray[newArrayIndex] = array[i];
            newArrayIndex++;
        }
    }
    return newArray;
}

string[] CreateArray(int size)
{
    string[] array = new string[size];

    int createArrayIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("enter " + (createArrayIndex + 1) + " array element");
        array[i] = Console.ReadLine()!;
        createArrayIndex++;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}