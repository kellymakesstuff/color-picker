using System.ComponentModel.DataAnnotations;
using ColorPicker.Models;

namespace ColorPicker.Dtos
{
  public class ColorCreateDto
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string HexCode { get; set; }
    [Required]
    public string RGBCode { get; set; }
    public string ComplimentColor { get; set; }


    [Required]
    public int FamilyId { get; set; }

  }
}