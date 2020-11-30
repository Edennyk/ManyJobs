using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Collections.Generic;
using ManyJobs.Models;
using Newtonsoft.Json;

namespace ManyJobsClient
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            
        }

       // Get all JobOffer data
        private async void btn_GetAllJO_Click(object sender, EventArgs e)
        {
            var response = await JobOfferHelper.GetAll();
            txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //POST JobOffer
        private async void btn_savejob_Click(object sender, EventArgs e)
        {
            var response = await JobOfferHelper.PostJobOffer(txt_jobName.Text, txt_jobTitle.Text,
                txt_Exp.Text, txt_jobSkill.Text, txt_address.Text, txt_salary.Text);
            txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //Search by JobOffer ID
        private async void btn_searchOffer_Click(object sender, EventArgs e)
        {
            var response = await JobOfferHelper.GetById(txt_idOffer.Text);
            txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //PUT JobOffer
        private async void btn_edit_Click(object sender, EventArgs e)
        {
           var response = await JobOfferHelper.PutJobOffer(txt_idOffer.Text,txt_jobName.Text, txt_jobTitle.Text,
           txt_Exp.Text, txt_jobSkill.Text, txt_address.Text, txt_salary.Text);
          txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //DELETE JobOffer
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            var response = await DeleteOffer(txt_idOffer.Text);
                txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //DELETE
        private async Task<string> DeleteOffer(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.DeleteAsync("http://jjin1112-eval-test.apigee.net/manyjobsproxy/api/joboffers" + id))
                {


                    using (HttpContent content = response.Content)
                    {
                        //MessageBox.Show(response.StatusCode.ToString());
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


        //======== Job Seeker =============================================

        //Get all data Job Seeker
        private async void btn_GetAllJS_Click(object sender, EventArgs e)
        {
            var response = await JobSeekerHelper.GetAll();
            txtResponse.Text = JobSeekerHelper.PrttierJson(response);
        }

        // Serach by id
        private async void btn_searchJS_Click(object sender, EventArgs e)
        {
            var response = await JobSeekerHelper.GetById(txt_idSeeker.Text);
            txtResponse.Text = JobSeekerHelper.PrttierJson(response);
        }


        //PUT
        private async void btn_editjs_Click(object sender, EventArgs e)
        {
            var response = await JobSeekerHelper.PutJobSeeker(txt_idSeeker.Text,txt_seekername.Text, txt_email.Text, 
                txt_major.Text,
            txt_seekerSkill.Text, txt_city.Text, txt_country.Text);
            txtResponse.Text = JobSeekerHelper.PrttierJson(response);
        }

        //POST
        private async void btn_saveseeker_Click(object sender, EventArgs e)
        {
            var response = await JobSeekerHelper.PostJobSeeker(txt_seekername.Text, txt_email.Text, 
                txt_major.Text,txt_seekerSkill.Text, txt_city.Text, txt_country.Text);
            txtResponse.Text = JobSeekerHelper.PrttierJson(response);
        }

        private async void btn_deletejs_Click(object sender, EventArgs e)
        {
            var response = await DeleteSeeker(txt_idSeeker.Text);
            txtResponse.Text = JobOfferHelper.PrttierJson(response);
        }

        //DELETE
        private async Task<string> DeleteSeeker(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.DeleteAsync("http://jjin1112-eval-test.apigee.net/manyjobsproxy/api/jobseekers" + id))
                {


                    using (HttpContent content = response.Content)
                    {
                        //MessageBox.Show(response.StatusCode.ToString());
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
