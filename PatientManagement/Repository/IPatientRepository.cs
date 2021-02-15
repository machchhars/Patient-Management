using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Repository
{
    public interface IPatientRepository
    {
        void Save(Patient patient);
    }
}
