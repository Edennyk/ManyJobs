using AutoMapper;
using ManyJobs.DTOs;
using ManyJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
           
        }
    }
}
