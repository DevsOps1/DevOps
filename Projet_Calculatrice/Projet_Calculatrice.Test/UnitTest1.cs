using NUnit.Framework;

namespace Projet_Calculatrice.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testadd()
        {
            int a = 15;
            int b = 65;
            calc calc = new calc();
            int result = calc.add(a, b);

            Assert.AreEqual(80, result);
        }

        [Test]
        public void TestMoins() 
        {
            int a = 22;
            int b = 11;
            calc calc = new calc();
            int result = calc.moins(a, b);
            Assert.AreEqual(11, result);
        }

        [Test]
        public void TestMulti()
        {
            int a = 2;
            int b = 11;
            calc calc = new calc();
            int result = calc.Multi(a, b);
            Assert.AreEqual(22, result);
        }

        [Test]
        public void Testdiv()
        {
            int a = 22;
            int b = 2;
            calc calc = new calc();
            int result = calc.div(a, b);
            Assert.AreEqual(11, result);
        }

        [Test]
        public void Testmod()
        {
            int a = 22;
            int b = 2;
            calc calc = new calc();
            int result = calc.modulo(a, b);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestPaire()
        {
            int a = 22;
            calc calc = new calc();
            bool result = calc.paireImpaire(a);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestPremier()
        {
            int a = 19;
            calc calc = new calc();
            bool result = calc.Premier(a);
            Assert.AreEqual(true, result);
        }
    }
}