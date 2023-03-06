string[] array1 = new string[9] {"Hello", "GB", "that","is", "my", "work", "ty","gl","=)"};
string[] array2 = new string[array1.Length];


void FillSecondArray(string[] array1, string[] array2)
{
    int indexarray2 = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[indexarray2] = array1[i];
        indexarray2++;
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
FillSecondArray(array1, array2);
PrintArray(array2);