using System;
using System.Collections.Generic;
using catlady.Models;
using catlady.Services;
using Microsoft.AspNetCore.Mvc;

namespace catlady.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CatsController : ControllerBase
  {
    private readonly CatsService _catsService;
    public CatsController(CatsService catsService)
    {
      _catsService = catsService;
    }



    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
      try
      {
        return Ok(_catsService.GetCats());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Cat> Create([FromBody] Cat newCat)
    {
      try
      {
        return Ok(_catsService.Create(newCat));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{catId}")]
    public ActionResult<Cat> GetById(string catId)
    {
      try
      {
        return Ok(_catsService.GetCatById(catId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{catId}")]
    public ActionResult<Cat> Delete(string catId)
    {
      try
      {
        return Ok(_catsService.DeleteCat(catId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{catId}")]
    public ActionResult<Cat> EditCat([FromBody] Cat body, string catId)
    {
      try
      {
        body.Id = catId;

        return Ok(_catsService.EditCat(body));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }


  }
}