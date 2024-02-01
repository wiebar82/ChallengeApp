namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGoToStatistic_ShouldReturnCorrectValue()
        {

            // arrange
            var employee = new Employee("Bartus", "Niunius");
            employee.AddGrade(7);
            employee.AddGrade(6.6f);
            employee.AddGrade(8);
            employee.AddGrade(-3);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(-3, statistics.Min);
            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(4.65f, statistics.Average);

        }
    }
}

