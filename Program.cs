string[] array = { "1234", "1567", "-2", "computer science","1" , "4444"};
string [] Concat(string[] Array)
{
    int data_length = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3  )
        {
            data_length += 1;
        }
    }

    string [] array_2 = new string [data_length];

    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3  )
        {
            array_2[count] = Array[i];
            count += 1;
        }
    }
    return array_2;
}
string [] inco = Concat(array);
System.Console.WriteLine(inco[0]);
System.Console.WriteLine(inco[1]);
System.Console.WriteLine(inco[2]);
System.Console.WriteLine(inco[3]);