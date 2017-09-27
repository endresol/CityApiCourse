using CityApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CityApi.Controllers
{   
    public class DummyController : Controller
    {
        private CityInfoContext _context;

        public DummyController(CityInfoContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }            
    }
}