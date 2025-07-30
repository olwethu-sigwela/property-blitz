using System.ComponentModel.DataAnnotations;



public class Listing
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public int NumBedrooms { get; set; }
    [Required]
    public string Location { get; set; } = string.Empty;
    [Required]
    public string Address { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string ImageURL { get; set; } = string.Empty;
}
