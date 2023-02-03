namespace HMIS.Models
{
    [Table("person_address_m")]
    public class PersonAdderess
    {

    [Key]
    [Column("id")]
    public int id { get; set; }
    
    [Column("PersonMasterId")]
    public int person_id { get; set; }
    
    [Column("Address1")]
    public string? Address1 { get; set; }
    
    [Column("Address2")]
    public string? Address2 { get; set; }

    [Column("city")]
    public string? city { get; set; }

    [Column("distict")]
    public string? distict { get; set; }

    [Column("state")]
    public string? state { get; set; }

    [StringLength(45)]
    [Column("postal_code")]
    public string? postal_code { get; set; }
    
    [Column("country")]
    public string? country { get; set; }
    
    [Column("created_date")]
    public DateTime created_date { get; set; }

    [Column("modified_date")]
    public DateTime modified_date { get; set; }

    [Column("created_user_id")]
    public Int32 created_user_id { get; set; }

    [Column("modified_user_id")]
    public Int32 modified_user_id { get; set; }

    [Column("created_location_id")]
    public Int32 created_location_id { get; set; }

    [Column("modified_location_id")]
    public Int32 modified_location_id { get; set; }

    [Column("is_active")]
    public Int32 is_active { get; set; }

    [Column("is_deleted")]
    public Int32 is_deleted { get; set; }

    }
}