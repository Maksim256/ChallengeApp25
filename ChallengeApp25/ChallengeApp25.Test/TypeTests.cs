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
            float number3 = 2.0f    ;
            float number4 = 2.0f;

            //act


            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number3, number4);

        }   

            
        

       
        
    }
}
