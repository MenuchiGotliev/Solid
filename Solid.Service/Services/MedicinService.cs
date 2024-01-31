using Solid.Core.Entities;

using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class MedicinService : IMedicinService
    {

        private readonly IMedicinRepository _medicineRepository;
        public MedicinService(IMedicinRepository medicineService)
        {
            _medicineRepository = medicineService;
        }
        public IEnumerable<Medicine> Get()
        {
            return _medicineRepository.Get();

        }

        public Medicine GetById(int id)
        {
            return _medicineRepository.GetById(id);
        }
        public void AddMedicin(Medicine value)
        {

            _medicineRepository.AddMedicin(value);
        }
        public void UpdateMedicin(int id, Medicine value)
        {
            _medicineRepository.UpdateMedicin(id, value);

        }
        public void DeleteMedicin(int id)
        {
            _medicineRepository.DeleteMedicin(id);

        }
    }
}