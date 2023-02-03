using System.ComponentModel.DataAnnotations;

namespace HMIS.Models
{
    public class SecurityUserMaster
    {
        [Key]
        [Column("id")]
        public int id { get; set; }
        [Column("username")]
        public string username { get; set; } = string.Empty;
        [Column("password")]
        public string password_hash { get; set; } = string.Empty;
        [Column("staff_id")]
        public int staff_id { get; set; }
        [Column("valid_from")]
        public DateTime valid_from { get; set; }
        [Column("valid_to")]
        public DateTime valid_to { get; set; }
        [Column("can_change_pwd")]
        public bool can_change_pwd { get; set; }
        [Column("tenent_id")]
        public int tenent_id { get; set; }
        [Column("created_date")]
        public DateTime created_date { get; set; }
        [Column("modified_date")]
        public DateTime modified_date { get; set; }
        [Column("created_user_id")]
        public int created_user_id { get; set; }
        [Column("modified_user_id")]
        public int modified_user_id { get; set; }
        [Column("created_location_id")]
        public int created_location_id { get; set; }
        [Column("modified_location_id")]
        public int modified_location_id { get; set; }
        [Column("is_active")]
        public int is_active { get; set; }
        [Column("is_deleted")]
        public int is_deleted { get; set; }
    }
}