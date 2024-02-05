using ChallengeApp;

var employee = new Employee("Bartek", "Wie");
employee.AddGrade(64443);
employee.AddGrade(7);
employee.AddGrade(4);
employee.AddGrade(5);
employee.AddGrade(3);

Console.WriteLine("GetStatisticWithForech");
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Minimum: {statistics.Min}");
Console.WriteLine($"Maximum: {statistics.Max}");
Console.WriteLine();
Console.WriteLine("GetStatisticsWithFor");
employee.AddGrade(4);
var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Minimum: {statistics1.Min}");
Console.WriteLine($"Maximum: {statistics1.Max}");
Console.WriteLine();
Console.WriteLine("GetStatisticsWithWhile");
employee.AddGrade(9);   
var statistics2 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Minimum: {statistics2.Min}");
Console.WriteLine($"Maximum: {statistics2.Max}");
Console.WriteLine();
Console.WriteLine("GetStatisticsWithDoWhile");
employee.AddGrade(3);
var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Minimum: {statistics3.Min}");
Console.WriteLine($"Maximum: {statistics3.Max}");

