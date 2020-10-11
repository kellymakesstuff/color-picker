using Microsoft.AspNetCore.Mvc;

namespace ColorPicker.Controllers
{

  //api/families
  [Route("api/[controller]")]
  [ApiController]

  //no views so inherit from ControllerBase instead of Controller
  public class FamiliesController : ControllerBase
  {

  }
}