using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCollections.FamilyDictionary
{
    class FamilyDictionary : ConsoleApp
    {
        public FamilyDictionary()
        {
            Name = "Family Dictionary";
        }
        public override void Run()
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("big sister", new Dictionary<string, string>() { { "name", "Jennifer" }, { "age", "40" } });
            myFamily.Add("little sister", new Dictionary<string, string>() { { "name", "Chrissy" }, { "age", "32" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Carolyn" }, { "age", "64" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Winford" }, { "age", "65" } });

            var familyMemberName = "";
            var familyMemberAge = "";

            foreach (var (member, descriptions) in myFamily)
            {
                foreach (var (description, value) in descriptions)
                {
                    if (description.Equals("name", StringComparison.OrdinalIgnoreCase))
                    {
                        familyMemberName = value;
                    }
                    else if (description.Equals("age", StringComparison.OrdinalIgnoreCase))
                    {
                        familyMemberAge = value;
                    }
                    else
                    {
                        Console.WriteLine($"Error in {member} description");
                    }
                }

                Console.WriteLine($"{familyMemberName} is my {member} and is {familyMemberAge} years old.");
            }

        }
    }
}
