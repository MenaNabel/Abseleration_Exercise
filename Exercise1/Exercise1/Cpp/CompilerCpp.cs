using System;
using System.Diagnostics;
using System.IO;

namespace Exercise1.Cpp
{
    public class CompilerCpp
    {
        public  static string CompileCppFile(string file)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.CreateNoWindow = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.StandardInput.WriteLine("cd "+ file);
                process.StandardInput.WriteLine("g++ TestFile.cpp -o  TestFile.exe");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                return file;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}