using System.Collections.Generic;
using ColorPicker.Models;

namespace ColorPicker.Data
{
  public class MockColorPickerRepo : IColorPickerRepo
  {
    public IEnumerable<Family> GetAllFamilies()
    {
      var families = new List<Family>
      {
        new Family { Id = 0, Name = "Red", Type = "Primary", Compliment = "Green" },
        new Family { Id = 1, Name = "Orange", Type = "Secondary", Compliment = "Purple" },
        new Family { Id = 2, Name = "Yellow", Type = "Primary", Compliment = "Blue" },
      };

      return families;

    }

    public Family GetFamilyById(int id)
    {
      return new Family { Id = 0, Name = "Red", Type = "Primary", Compliment = "Green" };
    }
  }
}