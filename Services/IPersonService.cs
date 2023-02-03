

using HMIS.DTO.Registration;

namespace HMIS.Services
{
    public interface IPersonService
    {
     Task<AddPersonDTO> Add(AddPersonDTO person);
     Task<UpdatePersonDTO> Update(UpdatePersonDTO person);

    }

    public interface IPersonServiceCenter{

        Task<AddServiceCenterDTO> Add(AddServiceCenterDTO person);
        Task<UpdateServiceCenterDTO> Update(UpdateServiceCenterDTO person);

        Task<IEnumerable<ServiceCenter>> search(String? name , String? desc , int? code );

        Task<AddSecurityUserMaster> Ragistor(AddSecurityUserMaster user);

        Task<string> Login(AddSecurityUserMaster user);

    }

}