using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;

namespace Exercise1.Cpp
{
    public class Generator
    {

        public static string GenerateCppFile()
        {
            try
            {
                string path = @"E:\TestFile.cpp";
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine(@"#include <iostream>
using namespace std;
 
int main() {                        
   cout << ""Hello World!"" << endl;  
   return 0;
            }
");
                tw.Close();
                return @"E:";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}