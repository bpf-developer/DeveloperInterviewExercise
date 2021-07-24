﻿using System;

namespace ThirdPartyTools
{
    public class FileDetails
    {
        private Static readonly Random _random = new Random();

        public Static string Version(string filePath)
        {
            return string.Format("{0}.{1}.{2}", _random.Next(5), _random.Next(8), _random.Next(22));
        }

        public Static int Size(string filePath)
        {
            return _random.Next(100000) + 1000000;
        }
    }
}
