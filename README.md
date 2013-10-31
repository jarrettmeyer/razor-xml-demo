Razor XML Demo
==============

Tired of creating XML files using [XmlWriter](http://msdn.microsoft.com/en-us/library/system.xml.xmlwriter.aspx),
[XmlDocument](http://msdn.microsoft.com/en-us/library/system.xml.xmldocument.aspx) or 
[XDocument](http://msdn.microsoft.com/en-us/library/system.xml.linq.xdocument.aspx). After looking at a few thousand lines
of declarative statements to build out a rather complex XML file for a client, I thought to myself, "There has
got to be a better way."

Hmmm.... Razor exists. It's just angle brackets. I wonder...

    csharp Template.cshtml
    @* Generator : Template TypeVisibility : Internal *@
    @using System.Collections.Generic
    @using RazorXmlDemo;

    @functions {
    public IEnumerable<XmlModel> Model { get; set; }
    }
    <?xml version="1.0" encoding="UTF-8"?>
    <People>
      @foreach (var m in Model)
      {
        <Person>
          <FirstName>@m.FirstName</FirstName>
          <LastName>@m.LastName</LastName>
        </Person>
      }    
    </People>

Be sure to include a `Generator` statement as the first line of code.

This project uses [RazorGenerator.Templating](http://www.nuget.org/packages/RazorGenerator.Templating/) to make the
magic happen.

