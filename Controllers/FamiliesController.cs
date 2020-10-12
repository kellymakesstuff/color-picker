using System.Collections.Generic;
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

    //constructor for dependency injection
    public FamiliesController(IColorPickerRepo repository)
    {
      _repository = repository;
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

