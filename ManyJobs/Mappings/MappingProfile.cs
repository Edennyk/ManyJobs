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
            CreateMap<JobSeeker, JobSeekerDto>(); //Map from Developer Object to DeveloperDTO Object
            CreateMap<JobOffer, JobOfferDto>();
        }
    }
}
