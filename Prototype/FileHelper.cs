using Prototype.File;
using System;
using System.Configuration;
using ThirdPartyTools;

namespace Prototype
{
    public static class FileHelper
    {
        public static IPrint GetFile(string[] args)
        {
            FileDetails fileDetails = new FileDetails();

            if (FileHelper.IsFileVersionArg(args))
            {
                return new FileVersion(fileDetails);
            }
            else if (FileHelper.IsFileSizeArg(args))
            {
                return new FileSize(fileDetails);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private static bool IsFileSizeArg(string[] args)
        {
            var configuration = FileHelper.GetConfigurationValues(Constants.Size, Constants.CommaSeperator);
            return FileValidator.Validate(configuration, args);
        }

        private static bool IsFileVersionArg(string[] args)
        {
            var configuration = FileHelper.GetConfigurationValues(Constants.Version, Constants.CommaSeperator);
            return FileValidator.Validate(configuration, args);
        }

        private static string[] GetConfigurationValues(string key, char seperator)
        {
            return ConfigurationManager.AppSettings.Get(key)?.Split(seperator);
        }
    }
}
