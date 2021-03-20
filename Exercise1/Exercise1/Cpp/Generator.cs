using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;
using Exercise1.Database;

namespace Exercise1.Cpp
{
    public class Generator
    {
        public static string GenerateCppFile()
        {
            
            try
            {
                ProgramsEntities context = new ProgramsEntities();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string file = path + @"\TestFile.cpp";
                TextWriter tw = new StreamWriter(file, true);
                tw.WriteLine(context.Programs.FirstOrDefault().ProgramText);
                tw.Close();
                return path;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}