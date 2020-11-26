using AutoMapper;
using ManyJobs.DTOs;
using ManyJobs.Models;

namespace ManyJobs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Job Offer Profile
            CreateMap<JobOffer, JobOfferDTO>(); // Read All 
            CreateMap<JobOfferCreateDTO, JobOffer>();
            CreateMap<JobOfferUpdateDTO, JobOffer>();
            CreateMap<JobOffer, JobOfferUpdateDTO>();

            // Job Seeker Profile
            CreateMap<JobSeeker, JobSeekerDTO>();
            CreateMap<JobSeekerCreateDTO, JobSeeker>();
            CreateMap<JobSeekerUpdateDTO, JobSeeker>();
            CreateMap<JobSeeker, JobSeekerUpdateDTO>();

        }
    }
}
