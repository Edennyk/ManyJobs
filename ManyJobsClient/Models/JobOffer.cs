using System;
using System.Collections.Generic;
using System.Text;

namespace ManyJobsClient.Models
{
    class JobOffer
    {
        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int jobId { get; set; }
            public string jobName { get; set; }
            public string jobTitle { get; set; }
            public string jobExperience { get; set; }
            public string skill { get; set; }
            public string jobAddress { get; set; }
            public string jobSalary { get; set; }
        }

    }
}
