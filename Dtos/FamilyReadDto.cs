using System.Collections.Generic;
using ColorPicker.Models;

namespace ColorPicker.Dtos
{
  public class FamilyReadDto
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Compliment { get; set; }

    // public IList<Color> Colors { get; set; } = new List<Color>();
  }
}