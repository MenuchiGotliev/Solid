

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
    public class ChemistService : IChemistService
    {
        private readonly IChemistRepository _chemistReposiory;
        public ChemistService(IChemistRepository chemistReposiory)
        {
            _chemistReposiory = chemistReposiory;
        }
        public IEnumerable<Chemist> Get()
        {
            return _chemistReposiory.Get();
        }
        public Chemist GetById(int id)
        {
            return _chemistReposiory.GetById(id);
        }
        public void AddChemist(Chemist chemist)
        {
            _chemistReposiory.AddChemist(chemist);
        }
        public void UpdateChemist(int id, Chemist value)
        {
            _chemistReposiory.UpdateChemist(id, value);
        }
        public void DeleteChemist(int id)
        {
            _chemistReposiory.DeleteChemist(id);
        }
    }
}
