
string[] forming_an_array_of_strings(string[] arr)
{
    string[] final_arr = new string[arr.Length];
    int count =0;
    for (int i =0; i<arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            final_arr[count]= arr[i];
            count++;
        }
    }
    return final_arr;
}


void PrintArray(string[] arr)
{
    Console.Clear();
    foreach (var s in arr)
    {
        if (s != null)
            Console.Write("\""+s+"\" ");
    }

    Console.WriteLine();
}

string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
string[] array2 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[3] { "Russia", "Denmark", "Kazan" };
PrintArray(forming_an_array_of_strings(array1));