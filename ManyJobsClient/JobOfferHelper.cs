using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace ManyJobsClient
{
    class JobOfferHelper
    {
        private static readonly string baseUrl = "http://manyjobs-test.us-east-1.elasticbeanstalk.com";
        private static readonly string apiKey = "CmUTHfc7KaDihUAdyKlX7AdvjM3nGXEh";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseUrl + "/api/joboffers"))
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
                using (HttpResponseMessage response = await client.GetAsync(baseUrl + "/api/joboffers" + id))
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
        public static async Task<string> PostJobOffer(string jobName, string jobTitle, string jobExperience, string skill,
            string jobAddress, string jobSalary)
        {
            var inputData = new Dictionary<string, string>
            {
                {"jobName", jobName },
                {"jobTitle", jobTitle },
                {"jobExperience", jobExperience },
                {"skill", skill },
                {"jobAddress", jobAddress },
                {"jobSalary", jobSalary },
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(baseUrl + "/api/joboffers", input))
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
        public static async Task<string> PutJobOffer(string id, string jobName, string jobTitle, string jobExperience, string skill,
            string jobAddress, string jobSalary)
        {
            var inputData = new Dictionary<string, string>
            {
                {"jobName", jobName },
                {"jobTitle", jobTitle },
                {"jobExperience", jobExperience },
                {"skill", skill },
                {"jobAddress", jobAddress },
                {"jobSalary", jobSalary },
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PutAsync(baseUrl + "/api/joboffers" + id, input))
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

