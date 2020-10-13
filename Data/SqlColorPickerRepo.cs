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

    public IEnumerable<Color> GetAllColors()
    {
      return _context.Colors.ToList();
    }
    public Family GetFamilyById(int id)
    {
      return _context.Families.FirstOrDefault(p => p.Id == id);
    }

    public Color GetColorById(int id)
    {
      return _context.Colors.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void CreateColor(Color clr)
    {
      if (clr == null)
      {
        throw new System.ArgumentNullException(nameof(clr));
      }
      _context.Colors.Add(clr);
    }
  }
}