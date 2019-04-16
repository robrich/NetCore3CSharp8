using System;

namespace CSharp8Playground
{
    /* Turn on in csproj:
    <LangVersion>8.0</LangVersion>
    <NullableContextOptions>enable</NullableContextOptions>
    */
    /* Turn on in file
#nullable enable
    */

    public class Student
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public static class NullableReferenceTypes
    {
        public static void Run()
        {

            Student s = new Student { FirstName = "Rob", LastName = "Richardson" };

            string fullName = $"{s.FirstName} {s.MiddleName.Substring(0, 1)} {s.LastName}";

            Console.WriteLine(fullName);


            // it isn't perfect:

            string blank = null;
            Console.WriteLine((blank == null));
            string def = default(string);
            Console.WriteLine((def == null));

        }
    }
}
