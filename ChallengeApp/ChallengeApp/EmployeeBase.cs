using System.Diagnostics;

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

        public virtual void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public virtual void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultInChar))
            {
                this.AddGrade(resultInChar);
            }
            else
            {
                throw new Exception("Greade is not a number");
            }
        }

        public abstract Statistics GetStatistics();
    }
}

