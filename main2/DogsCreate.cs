using System;
using System.Xml;
using System.Collections.Generic;

public static class DogXmlParser
{
    public static Dogs ParseDogsFromXml(string xmlFilePath)
    {
        Dogs dogs = new Dogs();

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlFilePath);

        XmlNodeList dogNodes = xmlDoc.SelectNodes("/Dogs/Dog");

        foreach (XmlNode dogNode in dogNodes)
        {
            Dog dog = new Dog
            {
                Name = dogNode.SelectSingleNode("Name").InnerText,
                Breed = dogNode.SelectSingleNode("Breed").InnerText,
                Age = int.Parse(dogNode.SelectSingleNode("Age").InnerText)
            };

            dogs.DogList.Add(dog);
        }

        return dogs;
    }
}
