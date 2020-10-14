using AutoMapper;
using ColorPicker.Dtos;
using ColorPicker.Models;


namespace ColorPicker.Profiles
{
  public class ColorsProfile : Profile
  {
    public ColorsProfile()
    {
      CreateMap<Color, ColorReadDto>();
      CreateMap<ColorCreateDto, Color>();
    }
  }
}