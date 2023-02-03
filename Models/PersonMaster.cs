
using System.Text.Json.Serialization;

namespace HMIS.Models
{
    [Table("person_m")]
    public class PersonMaster
    {       
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("Name_prefix")]
        public string? Name_prefix { get; set; }
        
        [Column("Name_suffix")]
        public string? Name_suffix { get; set; }

        [Column("S_name")]
        public string? S_name { get; set; }

        [Column("L_name")]
        public string? L_name { get; set; }


        [Column("Name_text")]
        public string Name_text { get; set; } 

        [Column("Name_Nickname")]
        public string? Name_Nickname { get; set; }

        [Column("email")]
        public string? email { get; set; }

        [Column("gender")]
        public string? gender { get; set; }
        
        [Column("birthDate")]
        public DateTime birthDate { get; set; }

        [Column("deceased_YN")]
        public Boolean deceased_YN { get; set; }

        [Column("deceasedDateTime")]
        public DateTime deceasedDateTime { get; set; }

        [Column("IsMarried")]
        public Boolean IsMarried { get; set; }

        [Column("Race")]
        public string Race { get; set; }

        [Column("Ethnicity")]
        public int Ethnicity { get; set; }

        [Column("BirthSex")]
        public string? BirthSex { get; set; }

        [Column("language_1")]
        public int language_1 { get; set; }

        [Column("language_2")]
        public int language_2 { get; set; }

        [Column("Photo")]
        public string? Photo { get; set; }

        [Column("natioanlity")]
        public string? natioanlity { get; set; }

        [Column("NationalIDNumber")]
        public Int32 NationalIDNumber { get; set; }

        [Column("PassortNumber")]
        public Int32? PassortNumber { get; set; }

        [Column("DLNumber")]
        public Int32? DLNumber { get; set; }

        [Column("id_type")]
        public Int32? id_type { get; set; }

        [Column("id_number")]
        public Int32? id_number { get; set; }

        [Column("Mobile")]
        public Int32? Mobile { get; set; }

        [Column("Phone_Home")]
        public Int32? Phone_Home { get; set; }

        [Column("Phone_Work")]
        public Int32? Phone_Work { get; set; }

         [Column("email_work")]
        public string? email_work { get; set; }

        [Column("created_date")]
        public DateTime? created_date { get; set; }

        [Column("modified_date")]
        public DateTime? modified_date { get; set; }

        [Column("created_user_id")]
        public Int32? created_user_id { get; set; }

        [Column("modified_user_id")]
        public Int32? modified_user_id { get; set; }

        [Column("created_location_id")]
        public Int32? created_location_id { get; set; }

        [Column("modified_location_id")]
        public Int32? modified_location_id { get; set; }

        [Column("is_active")]
        public Int32? is_active { get; set; }

        [Column("is_deleted")]
        public Int32? is_deleted { get; set; }

         public virtual List<PersonAdderess>? PersonAdderess { get; set; } 
    }
}