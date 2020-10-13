using System.Collections.Generic;
using ColorPicker.Models;

namespace ColorPicker.Data
{
  public interface IColorPickerRepo
  {
    bool SaveChanges();
    IEnumerable<Family> GetAllFamilies();
    Family GetFamilyById(int id);

    IEnumerable<Color> GetAllColors();
    Color GetColorById(int id);
    void CreateColor(Color clr);
  }
}