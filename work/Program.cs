
string[] baseArray = new string[6] {"item", "23", "1", "stuff", "ten", "job"};
string[] resultArr = new string[baseArray.Length];

void ArrayCheck(string[] arr, string[] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3) arr2[i] = arr[i];  
    }
}

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

ArrayCheck(baseArray, resultArr);
Print(resultArr);