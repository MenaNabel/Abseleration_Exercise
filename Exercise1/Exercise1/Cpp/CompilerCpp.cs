using System;
using System.Diagnostics;

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
                process.StandardInput.WriteLine(@"E:");
                process.StandardInput.WriteLine(@"cd E:\Projects\Apseleration\Exercise1");
                process.StandardInput.WriteLine("g++ TestFile.cpp -o  TestFile.exe");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                return @"E:\Projects\Apseleration\Exercise1\TestFile.exe";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}