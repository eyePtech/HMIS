using AutoMapper;
using HMIS.DTO.PersonServiceDTO;
using HMIS.DTO.Registration;

namespace HMIS
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddPersonDTO,PersonMaster>().ReverseMap();
            CreateMap<AddAddressDTO,PersonAdderess>().ReverseMap();
            CreateMap<UpdatePersonDTO,PersonMaster>().ReverseMap();
            CreateMap<AddServiceCenterDTO,ServiceCenter>().ReverseMap();
            CreateMap<UpdateServiceCenterDTO,ServiceCenter>().ReverseMap();
            CreateMap<AddSecurityUserMaster,SecurityUserMaster>().ReverseMap();
            
        }
    }
}