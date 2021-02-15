using PatientManagement.Data;
using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private PatientManagementDbContext _patientManagementDbContext;

        public PatientRepository(PatientManagementDbContext patientManagementDbContext)
        {
            _patientManagementDbContext = patientManagementDbContext;
        }

        public void Save(Patient patient)
        {
            _patientManagementDbContext.Patient.Add(patient);
            _patientManagementDbContext.SaveChanges();
        }

    }
}
