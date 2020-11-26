using ManyJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManyJobs.Services
{
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private readonly ManyJobsContext _context;

        public JobSeekerRepository(ManyJobsContext context)
        {
            _context = context;
        }

        // All data of JobSeeker
        public IEnumerable<JobSeeker> GetAllJobSeekers()
        {
            return _context.JobSeeker.ToList();
        }

        // Get data by JobSeeker ID
        public JobSeeker GetJobSeekerById(int id)
        {
            return _context.JobSeeker.FirstOrDefault(p => p.SeekerId == id);
        }

        // POST 
        public void CreateJobSeeker(JobSeeker jobSeeker)
        {
            if (jobSeeker == null)
            {
                throw new ArgumentNullException(nameof(jobSeeker));
            }
            _context.JobSeeker.Add(jobSeeker);
        }

        //PUT
        void IJobSeekerRepository.UpdateJobSeeker(JobSeeker jobSeeker) { }
       

        //DELETE
        public void DeleteJobSeeker(JobSeeker jobSeeker)
        {
            if (jobSeeker == null)
            {
                throw new ArgumentNullException(nameof(jobSeeker));
            }
            _context.JobSeeker.Remove(jobSeeker);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
