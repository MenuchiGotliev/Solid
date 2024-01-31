using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IMedicinRepository
    {
        IEnumerable<Medicine> Get();
        Medicine GetById(int id);
        void AddMedicin(Medicine value);
        void UpdateMedicin(int id, Medicine medicin);
        void DeleteMedicin(int id);
    }
}
