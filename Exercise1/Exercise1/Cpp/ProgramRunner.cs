using System.Diagnostics;

namespace Exercise1.Cpp
{
    public class ProgramRunner
    {
        public static string RunProgram(string prog)
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
            process.StandardInput.WriteLine("TestFile.exe");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            string str = process.StandardOutput.ReadToEnd().Trim();
            int indExe = str.IndexOf(".exe");
            string word = str.Substring(indExe + 5).Split('!')[0];
            return word;
        }
    }
}