using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Exercise1.Services
{
    public class CmdService
    {
        public string CmdCommand(string dir, string command)
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
                process.StandardInput.WriteLine(dir);
                process.StandardInput.WriteLine("g++ TestFile.cpp -o  TestFile.exe");
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                return process.StandardOutput.ReadToEnd().Trim();
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}