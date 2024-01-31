using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Service.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }
        public IEnumerable<Patient> Get()
        {
            return _patientRepository.Get();
        }
        public Patient GetById(int id)
        {

            return _patientRepository.GetById(id);
        }
        public void AddPatient(Patient value)
        {
            _patientRepository.AddPatient(value);
        }
        public void Update(int id, Patient value)
        {
            _patientRepository.Update(id, value);
        }
        public void DeletePatient(int id)
        {
            _patientRepository.DeletePatient(id);
        }
    }
}
