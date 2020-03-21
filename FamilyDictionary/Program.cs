using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Sarah" }, { "age", "38" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Chris" }, { "age", "40" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Clifford" }, { "age", "71" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Kimberly" }, { "age", "59" } });

            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old.");
            }
        }
    }
}
