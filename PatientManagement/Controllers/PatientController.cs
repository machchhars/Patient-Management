using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientManagement.Model;
using PatientManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientViewModel patientViewModel)
        {
            try
            {
                Patient patient = new Patient();
                patient.FirstName = patientViewModel.FirstName;
                patient.MiddleName = patientViewModel.MiddleName;
                patient.LastName = patientViewModel.LastName;
                patient.Gender = patientViewModel.Gender;
                patient.DOB = patientViewModel.DOB;
                patient.CaseType = patientViewModel.CaseType;
                if(!string.IsNullOrEmpty(patientViewModel.Photo))
                    patient.Photo = Convert.FromBase64String(patientViewModel.Photo);
                patient.PhotoType = patientViewModel.PhotoType;
                patient.PoliceEnquireRemark = patientViewModel.PoliceEnquireRemark;
                patient.PremanentAddress = patientViewModel.PremanentAddress;
                patient.PresentAddress = patientViewModel.PresentAddress;
                _patientRepository.Save(patient);
                return Ok(new { Message = "Patient added successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
