using System;
using NUnit.Framework;
using Plugin_Kernel;
//using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Plugin_KernelTests
{
    [TestFixture]
    public class ParameterTests
    {
        /// <summary>
        /// тест выреза Cut1 на нижнем цилиндре,
        /// а именно расчет координат, по которым будет осуществляться вырез
        /// </summary>
        /// <param name="radios1"></param>
        /// <param name="cut1"></param>
        /// <param name="shouldEquals"></param>
        [Test]
        [TestCase(200, 100, true, TestName ="Cut1 при Radios1=200")]
        [TestCase(0.000000000000003, 0.0000000000000015, true, TestName = "Cut1 при очень маленьком радиусе")]
        [TestCase(3, 1.5, true, TestName = "Cut1 при Radios1=3")]
        [TestCase(999, 499.5, true, TestName = "Cut1 при Radios1=999")]
        [TestCase(200, 101, false, TestName = "Неверный Cut1 при Radios1=200")]

        public void TestCut1 (double radios1, double cut1, bool shouldEquals)
        {
            var Parameters = new Parameters();
            Parameters.Radios1 = radios1;
            if (shouldEquals)
            {
                Assert.AreEqual(cut1, Parameters.Cut1);
            }
            else
            {
                Assert.AreNotEqual(cut1, Parameters.Cut1);
            }
            
        }

        /// <summary>
        /// тест параметра Cut2 - длина вырезания на нижней части цилиндра 
        /// </summary>
        /// <param name="lenght1"></param>
        /// <param name="cut2"></param>
        /// <param name="shouldEquals"></param>
        [Test]
        [TestCase(200, 160, true, TestName = "Cut2 при Lenght1=200")]
        [TestCase(0, 0, true, TestName = "Cut2 при Lenght1=0")]
        [TestCase(3, 2.4, true, TestName = "Cut2 при Lenght1=3")]
        [TestCase(999, 799.2, true, TestName = "Cut2 при Lenght1=999")]
        [TestCase(200, 101, false, TestName = "Неверный Cut2 при Lenght1=200")]

        public void TestCut2(double lenght1, double cut2, bool shouldEquals)
        {
            var Parameters = new Parameters();
            Parameters.Lenght1 = lenght1;
            if(shouldEquals)
            {
                Assert.AreEqual(cut2, Parameters.Cut2);
            }
            else
            {
                Assert.AreNotEqual(cut2, Parameters.Cut2);
            }
        }
    }
}
