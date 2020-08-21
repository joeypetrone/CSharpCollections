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

            foreach (var member in myFamily)
            {
                var familyMemberName = "";
                var familyMemberAge = "";

                foreach (var description in member.Value)
                {
                    if (description.Key == "name")
                    {
                        familyMemberName = description.Value;
                    }
                    else if (description.Key == "age")
                    {
                        familyMemberAge = description.Value;
                    }
                    else
                    {
                        Console.WriteLine($"Error in {member.Key} description");
                    }
                }

                Console.WriteLine($"{familyMemberName} is my {member.Key} and is {familyMemberAge} years old.");
            }

        }
    }
}
