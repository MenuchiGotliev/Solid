using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using Solid.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.Core.Controllers
{
    [Route("Pharmacy/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        //static List<Patient> patients = new List<Patient>
        //{
        //    new Patient(){Id = 123456789,Name = "Moshe",Adress = "Harav Shach 33",Age = 98},
        //    new Patient(){Id = 123456789,Name = "Yeuda",Adress = "Harav Sher 3",Age = 38},
        //    new Patient(){Id = 123456789,Name = "Shmuel",Adress = "Zonenfeld 11",Age = 28}
        //};

        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // GET: api/<ClientController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_patientService.Get());
        }

       
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_patientService.GetById(id));
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            _patientService.AddPatient(value);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient value)
        {
            _patientService.Update(id, value);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _patientService.DeletePatient(id);
        }
    }
}
