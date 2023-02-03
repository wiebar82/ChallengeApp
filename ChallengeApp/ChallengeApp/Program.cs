int age = 33;
string name = "Ewa";
char sex = 'F';

if (sex == 'M')
{
    if (age < 19)
    {
        Console.WriteLine("Mężczyza niepełnoletni.");
    }
    else 
    { 
        Console.WriteLine("Mężczyzna pełnoletni."); 
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30.");
    }
    else
    {
        if (name == "Ewa" && age == 33)
        {
            Console.WriteLine("Hura! Jest z nami Ewa lat 33!");
        }
        else
        { 
            Console.WriteLine("Inna kobieta powyżej 30-stki.");
        }
    }
}

Console.ReadLine();
