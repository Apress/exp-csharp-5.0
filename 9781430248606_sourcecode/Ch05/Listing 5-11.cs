using System;

namespace Ch05
{
    class Program
    {
        static void Main(string[] args)
        {
            var anObjectOfAnonymousType = new 				/* Anonymous type definition*/
            {
                Name = "Expert C# 5.0: with the .NET 4.5 Framework",	/* a string  type */
                Language = "C#",						/* a string  type */
                PublishedOn = 2012,						/* a int  type */
                Description = new DescriptionAboutBook("This book is about C#")	/* a DescriptionAboutBook
 									 * type */
            };

            Console.WriteLine("{0}\n{1}\n{2}\n{3}",
                anObjectOfAnonymousType.Name,
                anObjectOfAnonymousType.Language,
                anObjectOfAnonymousType.PublishedOn,
                anObjectOfAnonymousType.Description.Description);
        }
    }
    public class DescriptionAboutBook
    {
        public DescriptionAboutBook(string data)
        {
            Description = data;
        }
        public string Description { get; set; }
    }
}
