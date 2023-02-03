using System.ComponentModel.DataAnnotations;

namespace HMIS.Models
{
    public class ServiceCenter
    {
[Key][Column("id")] public int  id { get; set; }
[Column("code")] public int  code { get; set; } 
[Column("name")] public string name  { get; set; } = string.Empty;
[Column("department_id")] public int  department_id { get; set; }
[Column("phone")] public string phone { get; set; } = string.Empty;
[Column("type")] public int  type { get; set; }
[Column("desc")] public string desc { get; set; } = string.Empty;
[Column("created_date")] public DateTime created_date { get; set; }
[Column("modified_date")] public DateTime modified_date { get; set; }
[Column("created_user_id")] public int  created_user_id { get; set; }
[Column("modified_user_id")] public int  modified_user_id { get; set; }
[Column("created_location_id")] public int  created_location_id { get; set; }
[Column("modified_location_id")] public int  modified_location_id { get; set; }
[Column("is_active")] public int  is_active { get; set; }
[Column("is_deleted")] public int  is_deleted { get; set; }
    }
}