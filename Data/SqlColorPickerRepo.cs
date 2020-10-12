using System.Collections.Generic;
using System.Linq;
using ColorPicker.Models;

namespace ColorPicker.Data
{
  public class SqlColorPickerRepo : IColorPickerRepo
  {

    private readonly ColorPickerContext _context;

    public SqlColorPickerRepo(ColorPickerContext context)
    {
      _context = context;
    }

    public IEnumerable<Family> GetAllFamilies()
    {
      return _context.Families.ToList();
    }

    public Family GetFamilyById(int id)
    {
      return _context.Families.FirstOrDefault(p => p.Id == id);
    }
  }
}