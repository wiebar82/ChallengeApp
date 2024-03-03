using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        char Sex { get; }

        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;
        
        public Statistics GetStatistics();
    }
}
