using Microsoft.EntityFrameworkCore;
using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Data
{
    public class PatientManagementDbContext : DbContext
    {
        public PatientManagementDbContext(DbContextOptions<PatientManagementDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Patient> Patient { get; set; }
    }
}
