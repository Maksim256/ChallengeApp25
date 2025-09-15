using System.Reflection.Metadata;

namespace ChallengeApp25.Test
{
    public class Tests
    {




        [Test]
        public void WhenAverageForEmployee()
        {
            //arrange
            var employe = new EmployeeInFile("Adam", "haslo1");
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
            var employee = new EmployeeInFile("Adam2", "haslo2");
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
            var employee = new EmployeeInFile("John", "Doe");
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

        [Test]
        public void Dodanaocenaliterowasiezgadzazwartosciaami()
        {
            //arrange
            var employee = new EmployeeInFile("Jan", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('b');

            //act
            var statistics = employee.GetStatistics();


            //Assert

            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual(75, statistics.Average);


        }
    }
}