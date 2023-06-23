using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GuPackage.GuPackage;

namespace Gusharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuString s1 = new GuString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            GuString s2 = new GuString(new char[] { 'W', 'o', 'r', 'l', 'd' });
            GuString s3 = s1.GuConcat(s2);

            GuPrint(s3.ToGuString());
        }

        
    }
}
