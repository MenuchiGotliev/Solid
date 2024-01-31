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
    public class MedicinRepository:IMedicinRepository
    {
        private readonly DataContext _context;
        public MedicinRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Medicine> Get()
        {
            return _context.medicines;

        }

        public Medicine GetById(int id)
        {
            return _context.medicines.ToList().Find(m => m.Id == id);
        }
        public void AddMedicin(Medicine value)
        {
            
            _context.medicines.Add(value);
            _context.SaveChanges();
        }
        public void UpdateMedicin(int id, Medicine value)
        {
           
            Medicine m = _context.medicines.ToList().Find(m => m.Id == id);
            if (m != null)
            {
                m.Id = value.Id;
                m.Price = value.Price;
                m.Weight = value.Weight;
                m.Name = value.Name;
            }
            _context.SaveChanges();
        }
        public void DeleteMedicin(int id)
        {
            
            Medicine m = _context.medicines.ToList().Find(m => m.Id == id);
            if (m != null)
            {
                _context.medicines.Remove(m);
            }
            _context.SaveChanges();
        }

 
    }
}
