using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManyJobs.Models;

namespace ManyJobs.Services
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly ManyJobsContext manyJobsContext;

        public JobOfferRepository(ManyJobsContext manyJobsContext)
        {
            this.manyJobsContext = manyJobsContext;
        }

        public async Task<IEnumerable<JobOffer>> GetJobOffer()
        {
            return await manyJobsContext.JobOffer.ToListAsync();
        }

        public async Task <JobOffer> GetJobOffers(int jobId)
        {
            return await manyJobsContext.JobOffer.FirstOrDefaultAsync(f => f.JobId
            == jobId);
        }

        public async Task<JobOffer> AddJobOffer(JobOffer jobOffer)
        {
            var result = await manyJobsContext.JobOffer.AddAsync(jobOffer);
            await manyJobsContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<JobOffer> UpdateJobOffer(JobOffer jobOffer)
        {
            var result = await manyJobsContext.JobOffer
               .FirstOrDefaultAsync(f => f.JobId == jobOffer.JobId);

            if (result != null)
            {
                result.JobName = jobOffer.JobName;
                result.JobTitle = jobOffer.JobTitle;
                result.JobExperience = jobOffer.JobExperience;
                result.Skill = jobOffer.Skill;
                result.JobAddress = jobOffer.JobAddress;
                result.JobSalary = jobOffer.JobSalary;
              
                await manyJobsContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        public async void DeleteJobOffer(int jobId)
        {
            var result = await manyJobsContext.JobOffer.
                FirstOrDefaultAsync(f => f.JobId == jobId);
            if (result != null)
            {
                manyJobsContext.JobOffer.Remove(result);
                await manyJobsContext.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<JobOffer>> GetJobOffers()
        {
            throw new NotImplementedException();
        }

        public Task<JobOffer> GetJobOffer(int JobId)
        {
            throw new NotImplementedException();
        }
    }
}
