using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Type { get; set; }
  }
}