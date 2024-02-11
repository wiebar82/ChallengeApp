namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string firstName, string lastName, char sex)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public char Sex { get; private set; }
    }
}
