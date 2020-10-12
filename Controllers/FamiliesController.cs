using System.Collections.Generic;
using AutoMapper;
using ColorPicker.Data;
using ColorPicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColorPicker.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class FamiliesController : ControllerBase
  {
    private readonly IColorPickerRepo _repository;
    private readonly IMapper _mapper;

    //constructor for dependency injection
    public FamiliesController(IColorPickerRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    //api/families
    [HttpGet]
    public ActionResult<IEnumerable<Family>> GetFamiliesList()
    {
      var familyItems = _repository.GetAllFamilies();

      return Ok(familyItems);

    }

    //GET api/families/{id}
    [HttpGet("{id}")]
    public ActionResult<Family> GetFamilyById(int id)
    {
      var familyItem = _repository.GetFamilyById(id);
      if (familyItem != null)
      {
        return Ok(familyItem);
      }
      return NotFound();
    }
  }
}

