using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp25.Test
{
    public class TypeTests
    {
        [Test]
        public void PorownanieTypowWartosciowychPowinnyBycRowne()
        {

            // Testy do referencji i typów wartościowych

            //arrange


            int number1 = 2;
            int number2 = 2;
            //act


            //assert
            Assert.AreEqual(number1, number2);

        }   

            [Test]
            public void GetUserShoildReturnDifferentName()
            {
                var user1 = GetUser("Adam");
                var user2 = GetUser("Adam");
                Assert.AreNotEqual(user1, user2);
            }
        

        private User GetUser(string login)
        {
            return new User(login);
        }
       
        
    }
}
