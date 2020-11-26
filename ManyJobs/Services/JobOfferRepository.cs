using System;
using System.Collections.Generic;
using ManyJobs.Models;
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

        // All data of JobOffer
        public IEnumerable<JobOffer> GetAllJobOffers()
        {
            return _context.JobOffer.ToList();
        }

        // Get data by  JobOffer ID
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
        public void UpdateJobOffer(JobOffer jobOffer) { }
   

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

    }
}
