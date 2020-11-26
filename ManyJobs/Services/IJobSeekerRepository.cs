using ManyJobs.Models;
using System.Collections.Generic;


namespace ManyJobs.Services
{
    public interface IJobSeekerRepository
    {
        bool SaveChanges();
        IEnumerable<JobSeeker> GetAllJobSeekers();
        JobSeeker GetJobSeekerById(int SeekerId);
        void CreateJobSeeker(JobSeeker jobSeeker); //POST
        void UpdateJobSeeker(JobSeeker jobSeeker); //PUT
        void DeleteJobSeeker(JobSeeker jobSeeker);
    }
}
