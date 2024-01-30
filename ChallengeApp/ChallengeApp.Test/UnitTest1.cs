namespace ChallengeApp.Test
{
    public class Test
    {

        [Test]
        public void WhenEmployeeCollectPositivPoints_ShouldReturnResult()
        {

            // arrange
            var employee = new Employee("Bartus", "Niunius", 3);
            employee.AddPoints(7);
            employee.AddPoints(6);
            employee.AddPoints(8);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(21, result);

        }

        [Test]
        public void WhenEmployeeCollectNegativPoints_ShouldReturnResult()
        {

            // arrange
            var employee = new Employee("Wojtuœ", "Sykuœ", 6);
            employee.AddPoints(-7);
            employee.AddPoints(-6);
            employee.AddPoints(-3);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(-16, result);
        }

        [Test]
        public void WhenEmployeeCollectMixedPoints_ShouldReturnResult()
        {
            // arrange
            var employee = new Employee("Romuœ", "Pikuœ", 4);
            employee.AddPoints(5);
            employee.AddPoints(-6);
            employee.AddPoints(4);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(3, result);

        }
    }
}