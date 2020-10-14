using System.Collections.Generic;
using AutoMapper;
using ColorPicker.Data;
using ColorPicker.Dtos;
using ColorPicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColorPicker.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class ColorsController : ControllerBase
  {
    private readonly IColorPickerRepo _repository;
    private readonly IMapper _mapper;

    //constructor for dependency injection
    public ColorsController(IColorPickerRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    //api/colors
    [HttpGet]
    public ActionResult<IEnumerable<ColorReadDto>> GetColorsList()
    {
      var colorItems = _repository.GetAllColors();

      return Ok(_mapper.Map<IEnumerable<ColorReadDto>>(colorItems));

    }

    //GET api/colors/{id}
    [HttpGet("{id}", Name = "GetColorById")]
    public ActionResult<ColorReadDto> GetColorById(int id)
    {
      var colorItem = _repository.GetColorById(id);
      if (colorItem != null)
      {
        return Ok(_mapper.Map<ColorReadDto>(colorItem));
      }
      return NotFound();
    }

    //POST api/colors
    [HttpPost]
    public ActionResult<ColorReadDto> CreateColor(ColorCreateDto colorCreateDto)
    {
      var colorModel = _mapper.Map<Color>(colorCreateDto);
      _repository.CreateColor(colorModel);
      _repository.SaveChanges();

      var colorReadDto = _mapper.Map<ColorReadDto>(colorModel);
      return CreatedAtRoute(nameof(GetColorById), new { Id = colorReadDto.Id }, colorReadDto);
    }
  }
}

