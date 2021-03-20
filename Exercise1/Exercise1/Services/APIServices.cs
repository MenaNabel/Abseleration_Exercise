using Exercise1.Cpp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Exercise1.Services
{
    public class APIServices
    {
        public static HttpClient ApiClient { get; set; }
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
        }

        public static string path = Generator.GenerateCppFile();
        public static string compilePath = CompilerCpp.CompileCppFile(path);
        public static string word = ProgramRunner.RunProgram(compilePath);
        public static string readOutput()
        {
            return word;
        }
    }
}