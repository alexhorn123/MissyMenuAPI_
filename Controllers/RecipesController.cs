using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MissyMenuAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        // GET api/recipes
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Kale Salad", "Corn Salad", "Asian Salmon", "Tofu Stir Fry" };
        }
    }
}