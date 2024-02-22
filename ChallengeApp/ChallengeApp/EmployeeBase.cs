namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string firstName, string lastName, char sex)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public char Sex { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
