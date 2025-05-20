using System.Reflection.Metadata;

namespace ChallengeApp25.Test
{
    public class Tests
    {
        

        [Test]
        public void WhenTwoNumbersAreAdded_ShouldReturnSum()
        {
            //arrange
            int age1 = 10;
            int age2 = 3;

            //act
            int result = age1 + age2;

            //assert
            
            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenUseCollectTwoSetOfPoint_ShoultReturnCorrectSumAsResult()
        {
            //arrange
            var user = new User("Adam", "haslo1");
            user.AddScore(8);
            user.AddScore(7);
            user.OdejmijPunkty(1);

            //act

            var result = user.Result;
            
            //assert
            Assert.AreEqual(14, result);

        }

        [Test]
        public void WhenCollectTwoSetOfPoint_ShouldCorrecResultForEmployee()
        {
            //arrange
            var employee = new Employee("Adam2", "haslo2");
            employee.AddGrade(8);
            employee.AddGrade(1);
            //act
            var result = employee.GetStatistics;
            //assert
            Assert.AreEqual(9,result);
        }

        // testy do referencji i typów wartoœciowych

        
    }
}