using System.ComponentModel.DataAnnotations;

namespace ColorPicker.Models
{
  public class Color
  {
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string HexCode { get; set; }
    [Required]
    public string RGBCode { get; set; }
    public string ComplimentColor { get; set; }


    [Required]
    public int FamilyId { get; set; }
    public Family Family { get; set; }

  }
}