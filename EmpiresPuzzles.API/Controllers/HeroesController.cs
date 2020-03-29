using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpiresPuzzles.API.Interfaces;
using EmpiresPuzzles.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public IActionResult GetAll()
        {
            return Ok(_heroService.GetAll());
        }

        [HttpGet("{name}")]
        public IActionResult GetBy(string name)
        {
            return Ok(_heroService.GetBy(name));
        }
    }
}
