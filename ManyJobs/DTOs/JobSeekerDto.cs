using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyJobs.DTOs
{
    public class JobSeekerDto
    {
        public int SeekerId { get; set; }
        public string SeekerName { get; set; }
        public string SeekerEmail { get; set; }
        public string SeekerMajor { get; set; }
        public string Skill { get; set; }
        public string SeekerCity { get; set; }
        public string SeekerCountry { get; set; }
    }
}
