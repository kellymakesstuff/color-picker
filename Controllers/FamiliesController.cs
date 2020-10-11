using System.Collections.Generic;
using ColorPicker.Data;
using ColorPicker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColorPicker.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  //no views so inherit from ControllerBase instead of Controller
  public class FamiliesController : ControllerBase
  {
    private readonly MockColorPickerRepo _repository = new MockColorPickerRepo();

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

      return Ok(familyItem);
    }
  }

}