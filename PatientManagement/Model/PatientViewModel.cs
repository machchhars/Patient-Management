using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Model
{
    public class PatientViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string CaseType { get; set; }
        public string PoliceEnquireRemark { get; set; }
        public string PresentAddress { get; set; }
        public string PremanentAddress { get; set; }
        public string Photo { get; set; }
        public string PhotoType { get; set; }
    }
}
