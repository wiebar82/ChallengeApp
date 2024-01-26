int num = 3988467;

string numAsString = num.ToString();
char[] letters = numAsString.ToArray();

for (int i = 0; i <= 9; i++)
{
    int count = 0;

    foreach (char letter in letters)
    {

        if (letter == char.Parse(i.ToString()))
        {
            count++;
        }

    }
   
    Console.WriteLine(i + " => " + count);

}

