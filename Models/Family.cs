using System.Collections.Generic;

namespace ColorPicker.Models
{
  public class Family
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Compliment { get; set; }

    public IList<Color> Colors { get; set; } = new List<Color>();

  }
}