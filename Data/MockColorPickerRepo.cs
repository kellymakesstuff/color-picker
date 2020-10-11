using System.Collections.Generic;
using ColorPicker.Models;

namespace ColorPicker.Data
{
  public class MockColorPickerRepo : IColorPickerRepo
  {
    public IEnumerable<Family> GetAllFamilies()
    {
      throw new System.NotImplementedException();
    }

    public Family getFamilyById(int id)
    {
      throw new System.NotImplementedException();
    }
  }
}