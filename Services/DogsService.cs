using System;
using System.Collections.Generic;
using catlady.db;
using catlady.Models;

namespace catlady.Services
{
  public class DogsService
  {
    public IEnumerable<Dog> GetDogs()
    {
      return FAKEDB.Dogs;
    }

    public Dog Create(Dog newDog)
    {
      FAKEDB.Dogs.Add(newDog);
      return newDog;
    }

    public Dog GetDogById(string id)
    {
      Dog foundDog = FAKEDB.Dogs.Find(c => c.Id == id);
      if (foundDog != null)
      {
        return foundDog;
      }
      throw new Exception("No dog like that round these parts, partna");
    }
  }
}