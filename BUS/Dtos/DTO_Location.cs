using System.ComponentModel;

public class DTO_Location
{
    [DisplayName("Mã địa điểm")]
    public int Id { get; set; }

    [DisplayName("Tên địa điểm")]
    public string LocationName { get; set; }
}