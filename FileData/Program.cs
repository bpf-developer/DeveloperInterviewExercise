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
         args= new string[2];
         string a;
         string b;
         for(int i=0;i<args.Length<2;i++)
         {
             if(i==0)
                 a=args[i];
             
             if(i==1)
              b=args[i];
                       
           
         }
            string result;
            if(a=="-v")
            {
                FileDetails f= new FileDetails();
                result= f.Version(b);
                
                Console.ReadLine(result);
                
            }
        }
    }
}
