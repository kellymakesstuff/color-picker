using System.ComponentModel.DataAnnotations;

namespace ColorPicker.Dtos
{
  public class ColorUpdateDto
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

//refactor to use the same for create and update