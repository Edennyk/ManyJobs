using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManyJobs.Models;
using AutoMapper;
using System.Linq;

namespace ManyJobs.Services
{
    public class JobOfferRepository : IJobOfferRepository
    {
        private readonly ManyJobsContext _context;

        public JobOfferRepository(ManyJobsContext context)
        {
            _context = context;
        }

        // All data
        public IEnumerable<JobOffer> GetAllJobOffers()
        {
            return _context.JobOffer.ToList();
        }

        // get by ID
        public JobOffer GetJobOfferById(int id)
        {
            return _context.JobOffer.FirstOrDefault(p => p.JobId == id);
        }

        // POST 
        public void CreateJobOffer(JobOffer jobOffer)
        {
            if(jobOffer == null)
            {
                throw new ArgumentNullException(nameof(jobOffer));
            }
            _context.JobOffer.Add(jobOffer);
        }

        //PUT
        public void UpdateJobOffer(JobOffer jobOffer)
        {
            // This does nothing
        }

        // DELETE
        public void DeleteJobOffer(JobOffer jobOffer)
        {
            if (jobOffer == null)
            {
                throw new ArgumentNullException(nameof(jobOffer));
            }
            _context.JobOffer.Remove(jobOffer);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }





        /* private ManyJobsContext _manyJobsContext;

         public JobOfferRepository(ManyJobsContext manyJobsContext)
         {
             _manyJobsContext = manyJobsContext;
         }

         public async Task<bool> JobOfferExists(int JobId)
         {
             return await _manyJobsContext.JobOffer.AnyAsync<JobOffer>();
         }

         public async Task<IEnumerable<JobOffer>> GetJobOfferAll()
         {
             var result = _manyJobsContext.JobOffer.OrderBy(f => f.JobId);
             return await result.ToListAsync();
         }

         public async Task<JobOffer> GetJobOfferById(int jobId)
         {
             return await _manyJobsContext.JobOffer.FirstOrDefaultAsync
                 (f => f.JobId == jobId);
         }


         public async Task<JobOffer> AddJobOffer(JobOffer jobOffer)
         {
             var result = await _manyJobsContext.JobOffer.AddAsync(jobOffer);
             await _manyJobsContext.SaveChangesAsync();
             return result.Entity;
         }

         public async Task<JobOffer> UpdateJobOffer(JobOffer jobOffer)
         {
             var result = await _manyJobsContext.JobOffer
                .FirstOrDefaultAsync(f => f.JobId == jobOffer.JobId);

             if (result != null)
             {
                 result.JobName = jobOffer.JobName;
                 result.JobTitle = jobOffer.JobTitle;
                 result.JobExperience = jobOffer.JobExperience;
                 result.Skill = jobOffer.Skill;
                 result.JobAddress = jobOffer.JobAddress;
                 result.JobSalary = jobOffer.JobSalary;

                 await _manyJobsContext.SaveChangesAsync();

                 return result;
             }

             return null;
         }

         public async void DeleteJobOffer(int jobId)
         {
             var result = await _manyJobsContext.JobOffer.
                 FirstOrDefaultAsync(f => f.JobId == jobId);
             if (result != null)
             {
                 _manyJobsContext.JobOffer.Remove(result);
                 await _manyJobsContext.SaveChangesAsync();
             }
         }

         public Task<bool> Save()
         {
             throw new NotImplementedException();
         }*/

    }
}
