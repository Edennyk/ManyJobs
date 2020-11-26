using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyJobs.DTOs
{
    public class JobOfferCreateDTO
    {
        public string JobName { get; set; }
        public string JobTitle { get; set; }
        public string JobExperience { get; set; }
        public string Skill { get; set; }
        public string JobAddress { get; set; }
        public string JobSalary { get; set; }
    }
}
