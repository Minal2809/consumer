using API1.DataBa;
using API1.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CostmerController(DataSet data) : ControllerBase
{
  [HttpGet]
  public ActionResult<IEnumerable<AddCustom>> GetUser()
  {
    var Consm = data.MyCustomer.ToList();
    return Consm ;
  }
}
