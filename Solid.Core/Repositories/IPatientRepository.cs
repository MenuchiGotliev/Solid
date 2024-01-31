﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Entities;

namespace Solid.Core.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> Get();
        Patient GetById(int id);
        void AddPatient(Patient patient);
        void Update(int id, Patient patient);
        void DeletePatient(int id);
    }
}
