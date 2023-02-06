int number = 55679999;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

Console.WriteLine($"W liczbie " + number + " mamy następujące cyfry: ");
for (int j = 0; j < 10; j++)
{
    int count = 0;
    foreach (char letter in letters)
    {

        int charInNumber = letter - '0';
        if (charInNumber == j)
        {
            count++;
        }

    }
    Console.WriteLine(j + "--->" + count);

}

Console.ReadKey();