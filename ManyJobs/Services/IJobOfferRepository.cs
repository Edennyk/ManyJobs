using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManyJobs.Models;

namespace ManyJobs.Services
{
    public interface IJobOfferRepository
    {
        Task<IEnumerable<JobOffer>> GetJobOffers();
        Task<JobOffer> GetJobOffer(int JobId);
        Task<JobOffer> AddJobOffer(JobOffer jobOffer);
        Task<JobOffer> UpdateJobOffer(JobOffer jobOffer);
        void DeleteJobOffer(int JobId);
    }
}
