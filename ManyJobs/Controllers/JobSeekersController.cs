using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ManyJobs.Models;
using ManyJobs.DTOs;
using ManyJobs.Services;
using AutoMapper;


namespace ManyJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekersController : ControllerBase
    {
        private IJobSeekerRepository _jobSeekerRepository;
        private readonly IMapper _mapper;

        public JobSeekersController(IJobSeekerRepository jobSeekerRepository, IMapper mapper)
        {
            _jobSeekerRepository = jobSeekerRepository;
            _mapper = mapper;
        }

        // GET: api/JobSeekers (get all)
        [HttpGet]
        public ActionResult<IEnumerable<JobSeekerDTO>> GetAllJobSeekers()
        {
            var jobSeekerItems = _jobSeekerRepository.GetAllJobSeekers();
            var result = _mapper.Map<IEnumerable<JobSeekerDTO>>(jobSeekerItems);
            return Ok(result);
        }

        // GET: api/JobSeeker/5 (get by id)
        //[Authorize]
        [HttpGet]
        [Route("{id}", Name = "GetJobSeekerById")]
        public ActionResult<JobSeekerDTO> GetJobSeekerById(int id)
        {
            var jobSeekerItems = _jobSeekerRepository.GetJobSeekerById(id);

            if (jobSeekerItems == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<JobSeekerDTO>(jobSeekerItems);
            return Ok(result);
        }

        // POST: api/JobSeekers
        [HttpPost]
        public ActionResult<JobSeekerDTO> CreateJobSeeker(JobSeekerCreateDTO jobSeekerCreateDto)
        {
            var jobSeekerModel = _mapper.Map<JobSeeker>(jobSeekerCreateDto);
            _jobSeekerRepository.CreateJobSeeker(jobSeekerModel);
            _jobSeekerRepository.SaveChanges();

            var jobSeekerDto = _mapper.Map<JobSeekerDTO>(jobSeekerModel);

            //return Ok(JobSeekerDTO);
            return CreatedAtRoute(nameof(GetJobSeekerById), new { Id = jobSeekerDto.SeekerId }, jobSeekerDto);
        }

        // PUT: api/JobSeekers/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateJobSeeker(int id, JobSeekerUpdateDTO jobSeekerUpdateDto)
        {
            var jobSeekerModelFromRepo = _jobSeekerRepository.GetJobSeekerById(id);
            if (jobSeekerModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(jobSeekerUpdateDto, jobSeekerModelFromRepo);
            _jobSeekerRepository.UpdateJobSeeker(jobSeekerModelFromRepo);
            _jobSeekerRepository.SaveChanges();

            return NoContent();
        }


        // DELETE: api/JobSeekers/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteJobSeeker(int id)
        {
            var jobSeekerModelFromRepo = _jobSeekerRepository.GetJobSeekerById(id);
            if (jobSeekerModelFromRepo == null)
            {
                return NotFound();
            }

            _jobSeekerRepository.DeleteJobSeeker(jobSeekerModelFromRepo);
            _jobSeekerRepository.SaveChanges();

            return NoContent();
        }

    }
}
