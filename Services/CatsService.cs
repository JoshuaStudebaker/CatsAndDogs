using System;
using System.Collections.Generic;
using catlady.db;
using catlady.Models;

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
      throw new Exception("No cat like that round these parts, partna");
    }

    public Cat DeleteCats(string catId)
    {
      int index = FAKEDB.Cats.FindIndex(c => c.Id == catId)
      if (index != 0)
      {
        FAKEDB.Cats.RemoveAt(index)


      }
      throw new Exception("No cat like that round these parts, partna");

    }
  }
}