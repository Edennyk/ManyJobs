using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ManyJobsClient
{
    class JobSeekerHelper
    {
        private static readonly string baseUrl = "http://jjin1112-eval-test.apigee.net/manyjobsproxy";
        private static readonly string apiKey = "CmUTHfc7KaDihUAdyKlX7AdvjM3nGXEh";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseUrl + "/api/jobseekers"))
                {


                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }
            }
            return string.Empty;
        }

        public static string PrttierJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }


        // GET BY ID
        public static async Task<string> GetById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseUrl + "/api/jobseekers" + id))
                {


                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }
            }
            return string.Empty;
        }

        //POST
        public static async Task<string> PostJobSeeker(string seekerName, string seekerEmail, string seekerMajor, string skill,
            string seekerCity, string seekerCountry)
        {
            var inputData = new Dictionary<string, string>
            {
                {"jobName", seekerName },
                {"jobTitle", seekerEmail },
                {"jobExperience", seekerMajor },
                {"skill", skill },
                {"jobAddress", seekerCity },
                {"jobSalary", seekerCountry },
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(baseUrl + "/api/jobseekers", input))
                {


                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }
            }
            return string.Empty;
        }

        // PUT 
        public static async Task<string> PutJobSeeker(string id,string seekerName, string seekerEmail, string seekerMajor, string skill,
            string seekerCity, string seekerCountry)
        {
            var inputData = new Dictionary<string, string>
            {
                {"jobName", seekerName },
                {"jobTitle", seekerEmail },
                {"jobExperience", seekerMajor },
                {"skill", skill },
                {"jobAddress", seekerCity },
                {"jobSalary", seekerCountry },
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PutAsync(baseUrl + "/api/jobseekers" + id, input))
                {


                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }

                }
            }
            return string.Empty;
        }

    }

}




