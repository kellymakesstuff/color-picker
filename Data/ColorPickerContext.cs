using ColorPicker.Models;
using Microsoft.EntityFrameworkCore;


namespace ColorPicker.Data
{
  public class ColorPickerContext : DbContext
  {
    public ColorPickerContext(DbContextOptions<ColorPickerContext> opt) : base(opt)
    {

    }

    public DbSet<Family> Families { get; set; }
    public DbSet<Color> Colors { get; set; }
  }
}