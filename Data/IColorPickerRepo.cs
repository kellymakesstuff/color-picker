using System.Collections.Generic;
using ColorPicker.Models;

namespace ColorPicker.Data
{
  public interface IColorPickerRepo
  {
    IEnumerable<Family> GetAllFamilies();
    Family getFamilyById(int id);
  }
}