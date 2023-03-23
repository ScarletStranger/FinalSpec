string[] initialArray = new string[5] {"Serbia", "-164156", "git.exe", "1651.546", "conundrum"};
string[] finalArray = new string[initialArray.Length];

void SecondArrayWithIF(string[] initialArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
    if(initialArray[i].Length <= 3)
        {
        finalArray[count] = initialArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(initialArray, finalArray);
PrintArray(finalArray);