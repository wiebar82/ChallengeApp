using ChallengeApp;

Employee employee1 = new Employee("Bartek", "Wiecz", 42);
Employee employee2 = new Employee("Wojtek", "Kowa", 43);
Employee employee3 = new Employee("Zdzis", "Nowak", 42);


employee1.AddPoints(5);
employee1.AddPoints(2);
employee1.AddPoints(9);
employee1.AddPoints(5);
employee1.AddPoints(7);

employee2.AddPoints(8);
employee2.AddPoints(6);
employee2.AddPoints(9);
employee2.AddPoints(8);
employee2.AddPoints(7);

employee3.AddPoints(0);
employee3.AddPoints(0);
employee3.AddPoints(0);
employee3.AddPoints(0);
employee3.AddPoints(0);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownikiem z najlepszym wynikiem jest: " + employeeWithMaxResult.FirstName + " " + employeeWithMaxResult.LastName);
