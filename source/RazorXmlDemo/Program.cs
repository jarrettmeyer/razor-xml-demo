using System;
using System.Collections.Generic;

namespace RazorXmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = new Template();
            template.Model = new List<XmlModel>
            {
                new XmlModel { FirstName = "Alice", LastName = "Doe" },
                new XmlModel { FirstName = "Bob", LastName = "Doe" },
                new XmlModel { FirstName = "Cindy", LastName = "Doe" },
                new XmlModel { FirstName = "Doug", LastName = "Doe" },
            };
            //template.Execute();
            var text = template.TransformText().Trim();
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
