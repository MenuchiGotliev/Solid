using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using System.Xml.Linq;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Core.Controllers
{
    [Route("Pharmacy/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        //static List<Medicine> medicines = new List<Medicine>
        //{
        //    new Medicine(){Id = 1, Name = "Acamol",Price = 25,Weight = 15},
        //    new Medicine(){Id = 2, Name = "Nurofen",Price = 35,Weight = 25},
        //    new Medicine(){Id = 3, Name = "Advil",Price = 45,Weight = 55}

        //};
        private readonly IMedicinService _medicinrService;
        public MedicineController(IMedicinService medicinrService)
        {
            _medicinrService = medicinrService;
        }
        // GET: api/<MedicinController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicinrService.Get());
        }

        // GET api/<MedicinController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_medicinrService.GetById(id));

        }

        // POST api/<MedicinController>
        [HttpPost]
        public void Post([FromBody] Medicine value)
        {
            _medicinrService.AddMedicin(value);
        }

        // PUT api/<MedicinController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Medicine value)
        {
            _medicinrService.UpdateMedicin(id,value);
        }
        // DELETE api/<MedicinController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _medicinrService.DeleteMedicin(id);
        }
    }
}
