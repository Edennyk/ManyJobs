using ManyJobs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyJobs.Services
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private readonly ManyJobsContext manyJobsContext;

        public JobSeekerRepository(ManyJobsContext manyJobsContext)
        {
            this.manyJobsContext = manyJobsContext;
        }

        public async Task<IEnumerable<JobSeeker>> GetJobSeekers()
        {
            return await manyJobsContext.JobSeeker.ToListAsync();
        }

        public async Task<JobSeeker> GetJobSeeker(int SeekerId)
        {
            return await manyJobsContext.JobSeeker
                .FirstOrDefaultAsync(e => e.SeekerId == SeekerId);
        }

        public async Task<JobSeeker> AddJobSeeker(JobSeeker JobSeeker)
        {
            var result = await manyJobsContext.JobSeeker.AddAsync(JobSeeker);
            await manyJobsContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<JobSeeker> UpdateJobSeeker(JobSeeker JobSeeker)
        {
            var result = await manyJobsContext.JobSeeker
                .FirstOrDefaultAsync(e => e.SeekerId == JobSeeker.SeekerId);

            if (result != null)
            {
                result.SeekerId = JobSeeker.SeekerId;
                result.SeekerName = JobSeeker.SeekerName;
                result.SeekerEmail = JobSeeker.SeekerEmail;
                result.SeekerMajor = JobSeeker.SeekerMajor;
                result.Skill = JobSeeker.Skill;
                result.SeekerCity = JobSeeker.SeekerCity;
                result.SeekerCountry = JobSeeker.SeekerCountry;

                await manyJobsContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeleteJobSeeker(int SeekerId)
        {
            var result = await manyJobsContext.JobSeeker
                .FirstOrDefaultAsync(e => e.SeekerId == SeekerId);
            if (result != null)
            {
                manyJobsContext.JobSeeker.Remove(result);
                await manyJobsContext.SaveChangesAsync();
            }
        }

        Task<JobSeeker> IJobSeekerRepository.GetEmployee(int SeekerId)
        {
            throw new NotImplementedException();
        }

        Task<JobSeeker> IJobSeekerRepository.AddEmployee(JobSeeker jobSeeker)
        {
            throw new NotImplementedException();
        }

        Task<JobSeeker> IJobSeekerRepository.UpdateEmployee(JobSeeker jobSeeker)
        {
            throw new NotImplementedException();
        }
    }
}
