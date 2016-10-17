using System;

namespace Ch03
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNameWithDefaultValue();
            GetNameWithDefaultValue("Expert C# 5.0 by Mohammad Rahman", "C#");
        }

        public static void GetNameWithDefaultValue(
            string name = "Expert C# 5.0: with the .NET 4.5 Framework",
            string language = ": C#")
        {
            Console.WriteLine("{0} {1}", name, language);
        }
    }
}

