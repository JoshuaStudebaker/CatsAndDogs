using System;
using System.ComponentModel.DataAnnotations;

namespace Doglady.Models
{
  public class Dog
  {
    public Dog(string name, string breed, int barkLevel)
    {
      Name = name;
      Breed = breed;
      BarkLevel = barkLevel;
    }
    public Dog()
    {

    }

    [Required]
    [MinLength(3)]
    public string Name { get; set; }

    [Required]
    public string Breed { get; set; }
    [Required]

    [Range(1, 10)]
    public int BarkLevel { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();
  }
}