using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmpiresPuzzles.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public HeroesController(IHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Hero>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetAll() => Ok(_heroService.GetAll());

        [HttpGet("{name}")]
        [ProducesResponseType(typeof(Hero), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetBy(string name) => Ok(_heroService.GetBy(name));
    }
}
