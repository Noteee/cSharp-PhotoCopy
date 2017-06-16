using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCopy
{
    class Paths
    {
        string sourcePath = @"C:\Users\lugos\Desktop\noémi össze\101D3300";
        private string destinationPath1 = @"C:\Users\lugos\Desktop\apatest1";
        private string destinationPath2 = @"C:\Users\lugos\Desktop\apatest2";
        private string destinationPath3 = @"C:\Users\lugos\Desktop\apatest3";
        private string destinationPath4 = @"C:\Users\lugos\Desktop\apatest4";

        internal string getSourcePath()
        {
            return sourcePath;
        }

        internal string getdestinationPath1()
        {
            return destinationPath1;
        }

        internal string getdestinationPath2()
        {
            return destinationPath2;
        }

        internal string getdestinationPath3()
        {
            return destinationPath3;
        }

        internal string getdestinationPath4()
        {
            return destinationPath4;
        }
    }
}
