using System;

namespace Prototype
{
    public static class FileValidator
    {
        public static bool Validate(string[] configuration, string[] args)
        {
            return args?.Length > 1 && Array.IndexOf(configuration, args[0]) >= 0;
        }

    }
}
