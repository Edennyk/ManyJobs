using System;
using System.Collections.Generic;
using System.Text;

namespace ManyJobsClient.Models
{
    class JobSeeker
    {
        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int seekerId { get; set; }
            public string seekerName { get; set; }
            public string seekerEmail { get; set; }
            public string seekerMajor { get; set; }
            public string skill { get; set; }
            public string seekerCity { get; set; }
            public string seekerCountry { get; set; }
        }

    }
}
