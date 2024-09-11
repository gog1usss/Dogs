using System;
using System.Collections.Generic;

public class Dog
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
}

public class Dogs
{
    public List<Dog> DogList { get; set; } = new List<Dog>();
}
