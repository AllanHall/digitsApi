using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace digitsapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{x}")]
    public ActionResult<model> Explosion(string x)
    {
      var a = "";
      foreach (var l in x)
      {
        a += new String(l, int.Parse(l.ToString()));
      }

      return new model
      {
        input = x,
        result = a
      };
    }
  }
}