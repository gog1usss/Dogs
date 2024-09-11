using System;

public class Program
{
    public static void Main(string[] args)
    {
        string xmlFilePath =  @"C:\Users\maryn\source\repos\main2\main2\FileForDogs.xml";


        Dogs dogs = DogXmlParser.ParseDogsFromXml(xmlFilePath);

        foreach (Dog dog in dogs.DogList)
        {
            Console.WriteLine($"Name: {dog.Name}, Breed: {dog.Breed}, Age: {dog.Age}");
        }
    }
}
