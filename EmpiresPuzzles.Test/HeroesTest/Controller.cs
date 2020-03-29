using EmpiresPuzzles.API.Controllers;
using EmpiresPuzzles.API.Implementations.InMemoryService;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;

namespace EmpiresPuzzles.Test.HeroesTest
{
    public class Controller
    {
        private IHeroService heroService;
        private HeroesController controller;
        [SetUp]
        public void Setup()
        {
            heroService = new HeroService();
            controller = new HeroesController(heroService);
        }

        [Test]
        public void CallGetAll_ShouldReturnSomeData()
        {
            var result = controller.GetAll() as OkObjectResult;
            Assert.IsNotNull(result.Value);
        }

        [TestCase("Hikaru")]
        [TestCase("Sharan")]
        public void PassHeroName_ShouldReturnExpectedHeroName(string name)
        {
            var result = controller.GetBy(name) as OkObjectResult;
            var hero = result.Value as Hero;
            Assert.AreEqual(name, hero.Name);
        }

        [TestCase("Hikaru", typeof(OkObjectResult))]
        [TestCase("Sharan", typeof(OkObjectResult))]
        public void PassHeroName_ShouldReturnExpectedActionResultType(string name, Type expectedType)
        {
            var resultType = controller.GetBy(name).GetType();
            Assert.AreEqual(expectedType, resultType);
        }
    }
}