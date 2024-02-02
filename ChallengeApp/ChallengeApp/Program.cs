using ChallengeApp;

var employee = new Employee("Bartek", "Wie");
employee.AddGrade(64443);
employee.AddGrade(7);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Minimum: {statistics.Min}");
Console.WriteLine($"Maximum: {statistics.Max}");