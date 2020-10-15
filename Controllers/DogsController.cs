using System;
using System.Collections.Generic;
using catlady.Models;
using catlady.Services;
using Microsoft.AspNetCore.Mvc;

namespace catlady.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class DogsController : ControllerBase
  {
    private readonly DogsService _dogsService;
    public DogsController(DogsService dogsService)
    {
      _dogsService = dogsService;
    }



    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
      try
      {
        return Ok(_dogsService.GetDogs());
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Dog> Create([FromBody] Dog newDog)
    {
      try
      {
        return Ok(_dogsService.Create(newDog));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{dogId}")]
    public ActionResult<Dog> GetById(string dogId)
    {
      try
      {
        return Ok(_dogsService.GetDogById(dogId));
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }


  }
}