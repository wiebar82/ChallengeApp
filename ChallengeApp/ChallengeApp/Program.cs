﻿var name = "Ewa";
var sex = 'f';
var age = 30;

if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}