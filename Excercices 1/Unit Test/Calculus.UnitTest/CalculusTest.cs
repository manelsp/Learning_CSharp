using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
using NUnit.Framework;

namespace Calculus.UnitTest
{
    [TestFixture]
    public class CalculusTest
    {
        //MCM
        [TestCase(10, 11, ExpectedResult = 110)]
        [TestCase(3,  33, ExpectedResult = 33)]
        [TestCase(7,  25, ExpectedResult = 175)]
        public int MCM_IsWorking_ExpectedResoult(int num1, int num2)
        {
            MathCalculus.Calculus calculus = new MathCalculus.Calculus(num1, num2);

            int res = calculus.MCM();

            return res; 
        }

        //Multiplicacio>300
        [TestCase(10, 40)]
        public void Results_Higher300_EmptyList(int num1, int num2)
        {
            MathCalculus.Calculus calculus = new MathCalculus.Calculus(num1, num2);

            var result = calculus.results();

            Assert.That(result, Is.Empty); 
        }

        //Multiplicacio<300
        [TestCase(10, 10)]
        public void Results_Lower300_EmptyList(int num1, int num2)
        {
            MathCalculus.Calculus calculus = new MathCalculus.Calculus(num1, num2);

            var result = calculus.results();

            Assert.That(result, Is.Not.Empty);
        }

        //Obtenir tots els resultats de result
        [TestCase(5, 10)]
        public void Results_ObtainRes_6Res(int num1, int num2)
        {
            MathCalculus.Calculus calculus = new MathCalculus.Calculus(num1, num2);

            var result = calculus.results();

            Assert.That(result.Count(), Is.EqualTo(6));
        }
        
        //comprovar divisio 0 que no peti
        [TestCase (0,1)]
        public void Results_Zero_NoError(int num1, int num2)
        {
            MathCalculus.Calculus calculus = new MathCalculus.Calculus(num1, num2);

            var result = calculus.results();

            Assert.That(result, Does.Contain(0)); 
        }
       
    }
}
