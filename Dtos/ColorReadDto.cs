using ColorPicker.Models;

namespace ColorPicker.Dtos
{
  public class ColorReadDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string HexCode { get; set; }
    public string RGBCode { get; set; }
    public string ComplimentColor { get; set; }


    public int FamilyId { get; set; }

  }
}