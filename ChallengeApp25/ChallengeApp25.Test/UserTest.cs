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
            user.AddScore(5);
            user.AddScore(6);
            
            //act

            var result = user.Result;
            
            //assert
            Assert.AreEqual(11, result);

        }

        [Test]
        public void WhenCollectTwoSetOfPoint_ShouldCorrecrResultForEmployee()
        {
            //arrange
            var employee = new Employee("Adam2", "haslo2", 40);
            employee.DodajPunkty(4);
            employee.DodajPunkty(6);
            employee.OdejmijPunkty(1);
            //act
            var result = employee.Punkty;
            //assert
            Assert.AreEqual(10, result);
        }



    }
}