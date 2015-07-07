using System;
using System.CodeDom.Compiler;

using Pie;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            var file = new System.IO.StreamReader("Source/Fibonacci.pie");

            string code = file.ReadToEnd();
            file.Close();

            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = false;
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = "Fibonacci.exe";


            var provider = new PieCodeProvider();
            var results = provider.CompileAssemblyFromSource(parameters, code);

            foreach (CompilerError e in results.Errors)
                Console.WriteLine(e.ErrorText);

            Console.ReadKey();
        }
    }
}
