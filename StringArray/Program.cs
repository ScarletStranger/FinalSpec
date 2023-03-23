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

string[] initialArray = new string[5] {"Serbia", "xD", "git.exe", ":)", "res"};
string[] finalArray = new string[initialArray.Length];

SecondArrayWithIF(initialArray, finalArray);
PrintArray(finalArray);