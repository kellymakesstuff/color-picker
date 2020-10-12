using AutoMapper;
using ColorPicker.Dtos;
using ColorPicker.Models;


namespace ColorPicker.Profiles
{
  public class FamiliesProfile : Profile
  {
    public FamiliesProfile()
    {
      CreateMap<Family, FamilyReadDto>();
    }
  }
}