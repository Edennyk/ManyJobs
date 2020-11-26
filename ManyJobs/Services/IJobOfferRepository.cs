using System.Collections.Generic;
using ManyJobs.Models;

namespace ManyJobs.Services
{
    public interface IJobOfferRepository
    {
        bool SaveChanges();
        IEnumerable<JobOffer> GetAllJobOffers();
        JobOffer GetJobOfferById(int JobId);
        void CreateJobOffer(JobOffer jobOffer); //POST
        void UpdateJobOffer(JobOffer jobOffer); //PUT
        void DeleteJobOffer(JobOffer jobOffer);

    }
}
