using EmpiresPuzzles.API.Fluents;
using NUnit.Framework;
using System.Linq;

namespace EmpiresPuzzles.Test.Heroes
{
    public class FluentHeroTest
    {
        private IFluentHero fluentHero;
        [SetUp]
        public void Setup()
        {
            fluentHero = new API.InMemory.FluentHero();
        }

        [Test]
        public void CallGetAll_ShouldReturnSomeData()
        {
            var result = fluentHero.Get();
            Assert.IsNotNull(result);
        }

        [TestCase("Hikaru")]
        [TestCase("Sharan")]
        public void PassHeroName_ShouldReturnExpectedHeroName(string name)
        {
            var result = fluentHero.WithName(name).Get();
            Assert.AreEqual(name, result.FirstOrDefault().Name);
        }
    }
}