using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColorPicker.Models
{
  public class Family
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Compliment { get; set; }

    [Required]
    public IList<Color> Colors { get; set; } = new List<Color>();

  }
}