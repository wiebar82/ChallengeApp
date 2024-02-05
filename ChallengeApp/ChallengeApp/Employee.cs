namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value!");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= float.MinValue && grade <= float.MaxValue)
            {
                this.AddGrade(grade);
            }
            else
            {
                Console.WriteLine("Float value exceeded");
            }
        }
        public void AddGrade(decimal grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            
            for (int index = 0;  index < this.grades.Count; index++)
            {
                if(statistic.Max < grades[index])
                {
                    statistic.Max = grades[index];
                }
                if(statistic.Min > grades[index])
                {
                    statistic.Min = grades[index];
                }
                statistic.Average += grades[index];
            }
           statistic.Average /= this.grades.Count;
            return statistic;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            int index = 0;

            while (index < this.grades.Count) 
            {
                if (statistic.Max < grades[index])
                {
                    statistic.Max = grades[index];
                }
                if (statistic.Min > grades[index])
                {
                    statistic.Min = grades[index];
                }
                statistic.Average += grades[index];
                index++;
            }
            statistic.Average /= this.grades.Count;
            return statistic;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;
            int index = 0;

            do
            {
                if (statistic.Max < grades[index])
                {
                    statistic.Max = grades[index];
                }
                if (statistic.Min > grades[index])
                {
                    statistic.Min = grades[index];
                }
                statistic.Average += grades[index];
                index++;
            } while (index < this.grades.Count);

            statistic.Average /= this.grades.Count;
            return statistic;
        }

    }
}
