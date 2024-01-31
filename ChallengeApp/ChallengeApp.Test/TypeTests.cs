
namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void IntShouldbyEqual()
        {

            // arrange
            int num1 = 23;
            int num2 = 23;

            // assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void FloatSholdbyNotEqual()
        {
            // arrange
            float float1 = 3.12f;
            float float2 = 7.89f;

            // assert
            Assert.AreNotEqual(float1, float2);
        }

        [Test]
        public void TwoStringShouldbyNotEqual()
        {
            // arrange
            string animal1 = "kot";
            string animal2 = "pies";

            // assert
            Assert.AreNotEqual(animal1, animal2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {

            // arrange
            var emp1 = GetEmployee("Bartek", "Wer", 45);
            var emp2 = GetEmployee("Wojtek", "NCT", 36);

            // assert
            Assert.AreNotEqual(emp1, emp2);
        }

        private Employee GetEmployee(string name, string lastname, int age)
        {
            return new Employee(name, lastname, age);
        }
    }
}
