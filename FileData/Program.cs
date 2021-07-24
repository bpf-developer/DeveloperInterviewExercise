using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
             var args1 = args[0];
            var args2 = args[1];
             
            string v = FileDetails.Version(args2);
            Console.Write(v);

            string s = FileDetails.Version(args2);
        
            Console.Write(s);
            Console.ReadKey();
        }
    }
}
