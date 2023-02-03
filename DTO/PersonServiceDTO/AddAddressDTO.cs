namespace HMIS.DTO.PersonServiceDTO
{
    public class AddAddressDTO
    {
    public int id { get; set; }
    public int person_id { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? city { get; set; }
    public string? distict { get; set; }
    public string? state { get; set; }
    public string? postal_code { get; set; }
    public string? country { get; set; }
    public DateTime created_date { get; set; }
    public Int32 created_user_id { get; set; }
    public Int32 created_location_id { get; set; }
    public Int32 is_active { get; set; }
    public Int32 is_deleted { get; set; }

    }
}