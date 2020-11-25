using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManyJobs.Models;

namespace ManyJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekersController : ControllerBase
    {
        private readonly ManyJobsContext _context;

        public JobSeekersController(ManyJobsContext context)
        {
            _context = context;
        }

        // GET: api/JobSeekers
        [HttpGet]
        [Route("/api/getseekers")]
        public async Task<ActionResult<IEnumerable<JobSeeker>>> GetJobSeeker()
        {
            return await _context.JobSeeker.ToListAsync();
        }

        // GET: api/JobSeekers/5
        [HttpGet("{id}")]
        [Route("/api/getseekers/{id}")]
        public async Task<ActionResult<JobSeeker>> GetJobSeeker(int id)
        {
            var jobSeeker = await _context.JobSeeker.FindAsync(id);

            if (jobSeeker == null)
            {
                return NotFound();
            }

            return jobSeeker;
        }

        // PUT: api/JobSeekers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobSeeker(int id, JobSeeker jobSeeker)
        {
            if (id != jobSeeker.SeekerId)
            {
                return BadRequest();
            }

            _context.Entry(jobSeeker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobSeekerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/JobSeekers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<JobSeeker>> PostJobSeeker(JobSeeker jobSeeker)
        {
            _context.JobSeeker.Add(jobSeeker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobSeeker", new { id = jobSeeker.SeekerId }, jobSeeker);
        }

        // DELETE: api/JobSeekers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JobSeeker>> DeleteJobSeeker(int id)
        {
            var jobSeeker = await _context.JobSeeker.FindAsync(id);
            if (jobSeeker == null)
            {
                return NotFound();
            }

            _context.JobSeeker.Remove(jobSeeker);
            await _context.SaveChangesAsync();

            return jobSeeker;
        }

        private bool JobSeekerExists(int id)
        {
            return _context.JobSeeker.Any(e => e.SeekerId == id);
        }
    }
}
