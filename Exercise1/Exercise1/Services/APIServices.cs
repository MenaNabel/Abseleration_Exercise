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
        private static string path { get; set; }
        private static string compilePath { get; set; }
        private static string word { get; set; }
        public static HttpClient ApiClient { get; set; }
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            path = Generator.GenerateCppFile();
            compilePath = CompilerCpp.CompileCppFile(path);
            word = ProgramRunner.RunProgram(compilePath);
        }

        public static string readOutput()
        {
            return word;
        }
    }
}