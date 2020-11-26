using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManyJobs.Models;
using AutoMapper;
using ManyJobs.DTOs;
using ManyJobs.Services;
using Microsoft.AspNetCore.Authorization;

namespace ManyJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOffersController : ControllerBase
    {

        private IJobOfferRepository _jobOfferRepository;
        private readonly IMapper _mapper;

        public JobOffersController(IJobOfferRepository jobOfferRepository, IMapper mapper)
        {
            _jobOfferRepository = jobOfferRepository;
            _mapper = mapper;
        }

        // GET: api/JobOffers (get all)
        [HttpGet]
        [Route("/api/getoffers")]
        public ActionResult<IEnumerable<JobOfferDTO>> GetAllJobOffers()
        {
            var jobOfferItems = _jobOfferRepository.GetAllJobOffers();
            var result = _mapper.Map<IEnumerable<JobOfferDTO>>(jobOfferItems);
            return Ok(result);
        }

       // GET: api/JobOffers/5 (get by id)
        //[Authorize]
        [HttpGet]
        [Route("{id}", Name = "GetJobOfferById")]
        public ActionResult <JobOfferDTO> GetJobOfferById(int id)
        {    
            var jobOfferItems = _jobOfferRepository.GetJobOfferById(id);

            if (jobOfferItems == null)
            {
                return NotFound();
            }
             var result = _mapper.Map<JobOfferDTO>(jobOfferItems);
             return Ok(result);
        }

        // POST: api/JobOffers
        [HttpPost]
        public ActionResult<JobOfferDTO> CreateJobOffer (JobOfferCreateDTO jobOfferCreateDto)
        {
            var jobOfferModel = _mapper.Map<JobOffer>(jobOfferCreateDto);
            _jobOfferRepository.CreateJobOffer(jobOfferModel);
            _jobOfferRepository.SaveChanges();

            var jobOfferDto = _mapper.Map<JobOfferDTO>(jobOfferModel);

            //return Ok(JobOfferDTO);
            return CreatedAtRoute(nameof(GetJobOfferById), new { JobId = jobOfferDto.JobId },jobOfferDto);
        }


        // PUT: api/JobOffers/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateJobOffer(int id, JobOfferUpdateDTO jobOfferUpdateDto)
        {
            var jobOfferModelFromRepo = _jobOfferRepository.GetJobOfferById(id);
            if(jobOfferModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(jobOfferUpdateDto, jobOfferModelFromRepo);
            _jobOfferRepository.UpdateJobOffer(jobOfferModelFromRepo);
            _jobOfferRepository.SaveChanges();

            return NoContent();
        }


        // DELETE: api/JobOffers/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteJobOffer(int id)
        {
            var jobOfferModelFromRepo = _jobOfferRepository.GetJobOfferById(id);
            if (jobOfferModelFromRepo == null)
            {
                return NotFound();
            }

            _jobOfferRepository.DeleteJobOffer(jobOfferModelFromRepo);
            _jobOfferRepository.SaveChanges();

            return NoContent();
        }

       

      //=============================================================
        /*private IJobOfferRepository _jobOfferRepository;
        //private readonly ManyJobsContext _context;
        private readonly IMapper _mapper;

        public JobOffersController(ManyJobsContext context, IMapper mapper, IJobOfferRepository jobOfferRepository)
        {
          //  _context = context;
            _mapper = mapper;
            _jobOfferRepository = jobOfferRepository;
        }

        // GET: api/JobOffers
        [HttpGet]
        [Route("/api/getoffers")]
        public async Task<ActionResult<IEnumerable<JobOffer>>> GetJobOffer()
        {
            return await _context.JobOffer.ToListAsync();
        }

        // GET: api/JobOffers/5
        [HttpGet]
        [Route("/api/getoffers/{id}")]
        public async Task<ActionResult<JobOffer>> GetJobOffer(int id)
        {
            var jobOffer = await _context.JobOffer.FindAsync(id);

            if (jobOffer == null)
            {
                return NotFound();
            }

            return jobOffer;
        }

        // PUT: api/JobOffers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJobOffer(int id, JobOffer jobOffer)
        {
            if (id != jobOffer.JobId)
            {
                return BadRequest();
            }

            _context.Entry(jobOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobOfferExists(id))
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

        // POST: api/JobOffers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<JobOffer>> PostJobOffer(JobOffer jobOffer)
        {
            var jobOffers = await _context..JobOffer.Add(jobOffer);
            var jobOfferMapped = _mapper.Map<JobOfferDTO>(jobOffers);
            return Ok(jobOfferMapped);
            *//*_context.JobOffer.Add(jobOffer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJobOffer", new { id = jobOffer.JobId }, jobOffer);*//*
        }

        // DELETE: api/JobOffers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<JobOffer>> DeleteJobOffer(int id)
        {
            var jobOffer = await _context.JobOffer.FindAsync(id);
            if (jobOffer == null)
            {
                return NotFound();
            }

            _context.JobOffer.Remove(jobOffer);
            await _context.SaveChangesAsync();

            return jobOffer;
        }

        private bool JobOfferExists(int id)
        {
            return _context.JobOffer.Any(e => e.JobId == id);
        }*/
    }
}
