using System.Collections.Generic;
using catlady.Models;

namespace catlady.db
{
  public class FAKEDB
  {
    public static List<Cat> Cats { get; set; } = new List<Cat>(){
         new Cat("Snibbers", "Hes fat")
        };

    public static List<Dog> Dogs { get; set; } = new List<Dog>(){
         new Dog()
        };
  }
}
