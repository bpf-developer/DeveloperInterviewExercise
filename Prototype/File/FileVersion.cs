using System;
using ThirdPartyTools;

namespace Prototype.File
{
    public class FileVersion : IPrint
    {
        private readonly FileDetails _fileDetails;
        public FileVersion(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }
        public void Print(string version)
        {
            Console.WriteLine(_fileDetails.Version(version));
        }
    }
}
