
namespace ChallengeApp
{
   public class Employee
    {

        private List<int> points = new List<int>();
        public Employee(string firstName, string lasrName, int age) 
        {
            this.FirstName = firstName;
            this.LastName = lasrName;
            this.Age = age;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set;}

        public int Age { get; private set;}

        public int Result
        {
            get
            {
                return this.points.Sum();
            }
        }

        public void AddPoints(int newPoint)
        {
            this.points.Add(newPoint);
        }

    }
}
