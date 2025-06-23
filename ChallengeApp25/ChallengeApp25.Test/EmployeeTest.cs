using System.Reflection.Metadata;

namespace ChallengeApp25.Test
{
    public class Tests
    {




        [Test]
        public void WhenAverageForEmployee()
        {
            //arrange
            var employe = new Employee("Adam", "haslo1");
            employe.AddGrade(5);
            employe.AddGrade(9);

            //act

            var result = employe.GetStatistics().Average;

            //assert
            Assert.AreEqual(7, result);

        }

        [Test]
        public void WhenCollectTwoSetOfPoint_ShouldCorrecResultForEmployee()
        {
            //arrange
            var employee = new Employee("Adam2", "haslo2");
            // employee.AddGrade(8);
            //  employee.AddGrade(8);
            //act
            var result = employee.Equals;
            //assert
            // Assert.AreEqual(9 , result);
        }

        // testy do referencji i typów wartoœciowych

        [Test]
        public void WhenGetStatisticsForEmployee_ShouldReturnCorrectMinMaxAverage()
        {
            // Arrange
            var employee = new Employee("John", "Doe");
            employee.AddGrade(1.5f);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(3);

            // Act
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(Math.Round (1.5,2),Math.Round (statistics.Min,2 ));
            Assert.AreEqual(6, statistics.Max);
            Assert.AreEqual(3.125, statistics.Average ); // Allowing a small margin of error for floating point comparison    

        }
    }
}