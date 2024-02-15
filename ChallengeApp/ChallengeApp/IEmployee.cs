namespace ChallengeApp
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        char Sex { get; }

        public Statistics GetStatistics();
    }
}
