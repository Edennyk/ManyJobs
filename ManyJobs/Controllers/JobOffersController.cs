using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ManyJobs.Models;
using AutoMapper;
using ManyJobs.DTOs;
using ManyJobs.Services;


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
       // [Route("/api/getoffers")]
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
            return CreatedAtRoute(nameof(GetJobOfferById), new { Id = jobOfferDto.JobId },jobOfferDto);
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

    }
}
