using ChuckNorroeApi.Models;
using ChuckNorroeApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckNorroeApi.Controllers
{
    public class ChuckJokesController : Controller
    {
        private readonly IChuckJokesService _service;

        public ChuckJokesController(IChuckJokesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _service.GetRandomJoke();

            return View(model);
        }

        //public async Task<IActionResult> GetRandomJokesByCategory(CategoryViewModel c)
        //{
        //    var result = await _service.GetRandomJokesByCategory
        //}
    }
}
