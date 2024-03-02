namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGoToStatistic_ShouldReturnCorrectValue()
        {
            // arrange
            var employee = new EmployeeInMemory("Bartus", "Niunius", 'm');
            employee.AddGrade(7);
            employee.AddGrade(6.6f);
            employee.AddGrade(8);
            employee.AddGrade(3);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(6.15f, statistics.Average);
            Assert.AreEqual('E', statistics.AverageLetter);
        }

        [Test]
        public void WhenAddLetterGrade_ShouldReturnValue()
        {
            // arrange
            var employee = new EmployeeInMemory("Wojtus", "Nygus", 'm');
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');
            employee.AddGrade('a');
            // act
            var statistics = employee.GetStatistics(); 
            // assert
            Assert.AreEqual('A', statistics.AverageLetter);
        }
    }
}

