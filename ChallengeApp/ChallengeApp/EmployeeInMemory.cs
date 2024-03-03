namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
      
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string firstName, string lastName, char sex) 
            : base(firstName, lastName, sex)
        {
        }

        public override event GradeAddedDelegate GradeAdded;
      

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value!");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Sign isn't correct! You may use: A,a,B,b,C,c,D,d,E,e or grade from 0 to 100");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
       
            return statistics;
        }
    
    }
}
