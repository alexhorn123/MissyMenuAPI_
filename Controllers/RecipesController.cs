using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MissyMenuAPI.Models;
using MissyMenuAPI.Services;

namespace MissyMenuAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
 
        //[HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "Kale Salad", "Corn Salad", "Asian Salmon", "Tofu Stir Fry" };
        // }

        private readonly RecipesService _recipesService;

        public RecipesController(RecipesService recipesService) =>
        _recipesService = recipesService;

        [HttpGet]
        public async Task<List<Recipes>> Get() =>
        await _recipesService.GetAsync();
    }
}

        
