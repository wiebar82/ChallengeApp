using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string firstName, string lastName, char sex) 
            : base(firstName, lastName, sex)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value!");
            }
            
        }
        public override void AddGrade(char grade)
        {
            try
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
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            
        }
        public override void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }

        public override void AddGrade(int grade)
        {
           base.AddGrade(grade);
        }

        public override void AddGrade(string grade)
        {
            try
            {
                base.AddGrade(grade);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    var count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        count++;
                    }

                    result.Average /= count;

                    switch (result.Average)
                    {
                        case var average when average >= 80:
                            result.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            result.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            result.AverageLetter = 'C';
                            break;
                        case var average when average >= 20:
                            result.AverageLetter = 'D';
                            break;
                        default:
                            result.AverageLetter = 'E';
                            break;
                    }
                }
            }

            return result;
        }
    }
}

