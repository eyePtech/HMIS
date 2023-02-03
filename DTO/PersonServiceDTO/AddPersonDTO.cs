using System.Text.Json.Serialization;

namespace HMIS.DTO.PersonServiceDTO
{
    public class AddPersonDTO
    {       
        public int id { get; set; }
        public string? Name_prefix { get; set; }
        public string? Name_suffix { get; set; }
        public string? S_name { get; set; }
        public string? L_name { get; set; }
        [JsonIgnore]
        public string Name_text { get; set; }  = string.Empty;
        public string? Name_Nickname { get; set; }
        public string? email { get; set; }
        public string? gender { get; set; }
        public DateTime birthDate { get; set; }
        public Boolean deceased_YN { get; set; }
        public DateTime deceasedDateTime { get; set; }
        public Boolean IsMarried { get; set; }
        public string? Race { get; set; }
        public int Ethnicity { get; set; }
        public string? BirthSex { get; set; }
        public int language_1 { get; set; }
        public int language_2 { get; set; }
        public string? Photo { get; set; }
        public string? natioanlity { get; set; }
        public Int32 NationalIDNumber { get; set; }
        public Int32? PassortNumber { get; set; }
        public Int32? DLNumber { get; set; }
        public Int32? id_type { get; set; }
        public Int32? id_number { get; set; }
        public Int32? Mobile { get; set; }
        public Int32? Phone_Home { get; set; }
        public Int32? Phone_Work { get; set; }
        public string? email_work { get; set; }
        public DateTime? created_date { get; set; }
        public Int32? created_user_id { get; set; }
        public Int32? created_location_id { get; set; }
        public Int32? is_active { get; set; }
        public Int32? is_deleted { get; set; }

         public virtual List<AddAddressDTO>? PersonAdderess { get; set; } 
    }
}