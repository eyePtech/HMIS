using AutoMapper;
using HMIS.DTO.PersonServiceDTO;

namespace HMIS.Services
{
    public class PersonService : IPersonService
    {
        private readonly DataContext? _Context;
        private readonly IMapper _Mapper;
        public PersonService(DataContext context, IMapper mapper)
        {
            _Context = context;
            _Mapper = mapper;
        }

        public async Task<AddPersonDTO> Add(AddPersonDTO persondto)
        {
            persondto.created_date = DateTime.UtcNow;
            persondto.birthDate = persondto.birthDate.Date;
            persondto.deceasedDateTime = persondto.deceasedDateTime.Date;
            persondto.Name_text = persondto.Name_prefix + " " + persondto.S_name + " " + persondto.L_name + persondto.Name_suffix + " ";
            _Context.person_m.Add(_Mapper.Map<PersonMaster>(persondto));
            _Context.SaveChanges();
            return persondto;
        }

        public async Task<UpdatePersonDTO> Update(UpdatePersonDTO persondto)
        {

            var p = _Context.person_m.Find(persondto.id);
            // persondto.Name_prefix = persondto.Name_prefix == null? p.Name_prefix : persondto.Name_prefix;
            // persondto.Name_suffix = persondto.Name_suffix == null ? p.Name_suffix : persondto.Name_suffix;
            // persondto.S_name = persondto.S_name == null ? p.S_name : persondto.S_name;
            // persondto.L_name = persondto.L_name == null ? p.L_name : persondto.L_name;
            // persondto.Name_text = persondto.Name_prefix + " " + persondto.S_name + " " + persondto.L_name + persondto.Name_suffix + " ";
            // persondto.Name_Nickname = persondto.Name_Nickname == null ? p.Name_Nickname : persondto.Name_Nickname;
            // persondto.email = persondto.email == null ? p.email : persondto.email;
            // persondto.gender = persondto.gender == null ? p.gender : persondto.gender;
            // persondto.birthDate = persondto.birthDate == null ? p.birthDate : persondto.birthDate;
            // persondto.deceased_YN = persondto.deceased_YN == null ? p.deceased_YN : persondto.deceased_YN;
            // persondto.deceasedDateTime = persondto.deceasedDateTime == null ? p.deceasedDateTime : persondto.deceasedDateTime;
            // persondto.IsMarried = persondto.IsMarried == null ? p.IsMarried : persondto.IsMarried;
            // persondto.Race = persondto.Race == null ? p.Race : persondto.Race;
            // persondto.Ethnicity = persondto.Ethnicity == null ? p.Ethnicity : persondto.Ethnicity;
            // persondto.BirthSex = persondto.BirthSex == null ? p.BirthSex : persondto.BirthSex;
            // persondto.language_1 = persondto.language_1 == null ? p.language_1 : persondto.language_1;
            // persondto.language_2 = persondto.language_2 == null ? p.language_2 : persondto.language_2;
            // persondto.Photo = persondto.Photo == null ? p.Photo : persondto.Photo;
            // persondto.natioanlity = persondto.natioanlity == null ? p.natioanlity : persondto.natioanlity;
            // persondto.NationalIDNumber = persondto.NationalIDNumber == null ? p.NationalIDNumber : persondto.NationalIDNumber;
            // persondto.PassortNumber = persondto.PassortNumber == null ? p.PassortNumber : persondto.PassortNumber;
            // persondto.DLNumber = persondto.DLNumber == null ? p.DLNumber : persondto.DLNumber;
            // persondto.id_type = persondto.id_type == null ? p.id_type : persondto.id_type;
            // persondto.id_number = persondto.id_number == null ? p.id_number : persondto.id_number;
            // persondto.Mobile = persondto.Mobile == null ? p.Mobile : persondto.Mobile;
            // persondto.Phone_Home = persondto.Phone_Home == null ? p.Phone_Home : persondto.Phone_Home;
            // persondto.Phone_Work = persondto.Phone_Work == null ? p.Phone_Work : persondto.Phone_Work;
            // persondto.email_work = persondto.email_work == null ? p.email_work : persondto.email_work;
            // persondto.modified_date = DateTime.UtcNow;
            // persondto.modified_user_id  = persondto.modified_user_id == null ? p.modified_user_id : persondto.modified_user_id;
            // persondto.modified_location_id  = persondto.modified_location_id == null ? p.modified_location_id : persondto.modified_location_id;
            // persondto.is_active  = persondto.is_active == null ? p.is_active : persondto.is_active;
            // persondto.is_deleted  = persondto.is_deleted == null ? p.is_deleted : persondto.is_deleted;
            _Mapper.Map(persondto,p);
            _Context.SaveChanges();
            return persondto;

        }
    }
}