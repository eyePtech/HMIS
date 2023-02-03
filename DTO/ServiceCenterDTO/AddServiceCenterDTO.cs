namespace HMIS.DTO.ServiceCenterDTO
{
    public class AddServiceCenterDTO
    {

public int  id { get; set; }

public int  code { get; set; } 

public string name  { get; set; } = string.Empty;

public int  department_id { get; set; }

public string phone { get; set; } = string.Empty;

public int  type { get; set; }
 
public string desc { get; set; } = string.Empty;
public DateTime created_date { get; set; }
public int  created_user_id { get; set; }
public int  created_location_id { get; set; }
public int  is_active { get; set; }
public int  is_deleted { get; set; }
    }
}