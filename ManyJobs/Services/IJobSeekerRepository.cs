using ManyJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyJobs.Services
{
    public interface IJobSeekerRepository
    {
        Task<IEnumerable<JobSeeker>> GetJobSeekers();
        Task<JobSeeker> GetEmployee(int SeekerId);
        Task<JobSeeker> AddEmployee(JobSeeker jobSeeker);
        Task<JobSeeker> UpdateEmployee(JobSeeker jobSeeker);
        void DeleteJobSeeker(int SeekerId);
    }
}
