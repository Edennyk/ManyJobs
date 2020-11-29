using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyJobsClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /*[STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/

        static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            RunAsyn().GetAwaiter().GetResult();
        }

        static async Task RunAsyn()
        {
            client.BaseAddress = new Uri("http://jjin1112-eval-test.apigee.net/manyjobsproxy/api/joboffers.json");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("apikey", "CmUTHfc7KaDihUAdyKlX7AdvjM3nGXEh");

            try
            {
                string json;
                HttpResponseMessage response;

                //Get all items
                response = await client.GetAsync("/api/joboffers.json");
                response = await client.GetAsync("/api/jobseekers.json");

                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();

                    IEnumerable<JobOffer> joboffers = JsonConvert.DeserializeObject<IEnumerable<JobOffer>>(json);
                    foreach (JobOffer joboffer in joboffers)
                    {
                        Console.WriteLine(joboffer);
                    }
                }
                else
                    Console.WriteLine("Internal Server error");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
