using System;
using System.Collections.Generic;
using catlady.db;
using catlady.Models;
using System.Linq;

namespace catlady.Services
{
  public class CatsService
  {
    public IEnumerable<Cat> GetCats()
    {
      return FAKEDB.Cats;
    }

    public Cat Create(Cat newCat)
    {
      FAKEDB.Cats.Add(newCat);
      return newCat;
    }

    public Cat GetCatById(string id)
    {
      Cat foundCat = FAKEDB.Cats.Find(c => c.Id == id);
      if (foundCat != null)
      {
        return foundCat;
      }
      throw new Exception("No cat like that round these parts, partner");
    }

    public Cat DeleteCat(string catId)
    {
      int index = FAKEDB.Cats.FindIndex(c => c.Id == catId);
      if (index != -1)
      {
        FAKEDB.Cats.RemoveAt(index);
        throw new Exception("Successfully deleted");


      }
      throw new Exception("No cat like that round these parts, partner");

    }

    public Cat EditCat(Cat body)
    {
      Cat foundCat = FAKEDB.Cats.Find(c => c.Id == body.Id);
      if (foundCat != null)
      {
        foundCat.Name = body.Name != null ? body.Name : foundCat.Name;
        foundCat.Description = body.Description != null ? body.Description : foundCat.Description;
        foundCat.Id = body.Id;
        FAKEDB.Cats.Remove(foundCat);
        FAKEDB.Cats.Add(foundCat);
        return foundCat;

      }
      throw new Exception("No cat like that round these parts, partner");
    }
  }
}