using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solid.Core.Services;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Core.Controllers
{
    [Route("Pharmacy/[controller]")]
    [ApiController]
   
    public class ChemistController : ControllerBase
    {
        //static List<Chemist> chemists = new List<Chemist>
        //{
        //    new Chemist(){Id = 325963014,Name = "Alex",Adress = "Cineret 2",Age =35},
        //    new Chemist(){Id = 214375528,Name = "Yosi",Adress = "Flowers 3",Age =40},
        //    new Chemist(){Id = 315398877,Name = "Musa",Adress = "Atiya 4",Age =23}

        //};
        private readonly IChemistService _chemistService;
        public ChemistController(IChemistService chemistService)
        {
            _chemistService = chemistService;
        }
        // GET: api/<ChemistController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_chemistService.Get());
        }


        // GET api/<ChemistController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_chemistService.GetById(id));
        }

        // POST api/<ChemistController>
        [HttpPost]
        public void Post([FromBody] Chemist chemist)
        {
            _chemistService.AddChemist(chemist);
        }

        // PUT api/<ChemistController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Chemist value)
        {
            _chemistService.UpdateChemist(id, value);

        }

        // DELETE api/<ChemistController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _chemistService.DeleteChemist(id);
        }
    }
}
