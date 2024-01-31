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
    public class ChemistRepository:IChemistRepository
    {
        private readonly DataContext _context;
        public ChemistRepository(DataContext context)
        {
            _context = context;
        }
       public IEnumerable<Chemist> Get()
        {
            
            return _context.chemists;
        }
        public Chemist GetById(int id)
        {
           
            return _context.chemists.ToList().Find(c => c.Id == id);
        }
        public void AddChemist(Chemist chemist)
        {
           
            _context.chemists.Add(chemist);
            _context.SaveChanges();
        }
        public void UpdateChemist(int id, Chemist value)
        {
            
            Chemist chemist = _context.chemists.ToList().Find(c => c.Id == id);
            if (chemist != null)
            {
                chemist.Id = value.Id;
                chemist.Name = value.Name;
                chemist.Age = value.Age;
                chemist.Adress = value.Adress;
            }
            _context.SaveChanges();
        }
        public void DeleteChemist(int id)
        {
           
            Chemist chemist = _context.chemists.ToList().Find(c => c.Id == id);
            if (chemist != null)
            {
                _context.chemists.Remove(chemist);
            }
            _context.SaveChanges();
        }
    }
}
