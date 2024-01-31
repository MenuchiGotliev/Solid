using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;


namespace Solid.Core.Repositories
{
    public interface IChemistRepository
    {
        IEnumerable<Chemist> Get();
        Chemist GetById(int id);
        void AddChemist(Chemist chemist);
        void UpdateChemist(int id,Chemist chemist);
        void DeleteChemist(int id);
    }
      
}
