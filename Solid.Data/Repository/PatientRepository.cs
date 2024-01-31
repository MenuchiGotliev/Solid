using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core;
using Solid.Core.Entities;



namespace Solid.Data.Repository
{
    public class PatientRepository:IPatientRepository
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> Get()
        {
            return _context.patients;
        }
        public Patient GetById(int id)
        {

            return _context.patients.ToList().Find(p => p.Id == id);
        }
        public void AddPatient(Patient value)
        {
           
            _context.patients.Add(value);
            _context.SaveChanges();
        }
        public void Update(int id, Patient value)
        {
           
            Patient p = _context.patients.ToList().Find(p => p.Id == id);
            if (p != null)
            {
                p.Id = value.Id;
                p.Name = value.Name;
                p.Age = value.Age;
                p.Adress = value.Adress;
            }
            _context.SaveChanges();
        }
        public void DeletePatient(int id)
        {
            
            Patient p = _context.patients.ToList().Find(p => p.Id == id);
            _context.patients.Remove(p);
            _context.SaveChanges();
        }
    }
}
