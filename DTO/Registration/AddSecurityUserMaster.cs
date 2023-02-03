namespace HMIS.DTO.Registration
{
    public class AddSecurityUserMaster
    {
        public int id { get; set; }
        public string username { get; set; } = string.Empty;
        public string password_hash { get; set; } = string.Empty;
        public int staff_id { get; set; }
        public DateTime valid_from { get; set; }
        public DateTime valid_to { get; set; }
        public bool can_change_pwd { get; set; }
        public int tenent_id { get; set; }
        public DateTime created_date { get; set; }
        public int created_user_id { get; set; }
        public int created_location_id { get; set; }
        public int is_active { get; set; }
        public int is_deleted { get; set; }
    }
}