using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace digitsapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("{y}")]
    public ActionResult<model> Mumbling(string y)
    {
      var a = "";
      var i = 0;
      ///abc => A-Bb-Ccc
      foreach (char l in y)
      {
        a += char.ToUpper(l) + new String(char.ToLower(l), i) + "-";
        i++;
      }

      return new model
      {
        input = y,
        result = a.TrimEnd('-')
      };
    }
  }
}