using System;

namespace DateLibraryModule-1
{
    public class Class1
    {
        public static string Output(string name)
        {
            var line = $"Current time {DateTime.UtcNow.ToLongTimeString()}. Name {name}!";
            return line;

        }
    }
}

