string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan" };

int NewArrayLenght(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] resultArray = new string[NewArrayLenght(array)];


for (int i = 0; i < resultArray.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            resultArray[i] = array[j];
            i++;
        }
    }
}





System.Console.WriteLine(string.Join(", ", resultArray));