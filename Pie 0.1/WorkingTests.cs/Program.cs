using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Pie;

namespace WorkingTests.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new System.IO.StreamReader("Tests/test.pie");

            string code = file.ReadToEnd();
            file.Close();

            var root = new Pie.Expressions.Root();

            code = @"
                            class foo 
                                of T, F";

            var parser = Pie.Parser.Create();
            parser.Parse(root, code);
            
            foreach (CompilerError e in root.CompilerErrors)
            {
                Console.WriteLine(e.ErrorNumber + ", " + e.Line + ", " + e.Column + ": " + e.ErrorText);
            }

           /* if (results.Errors.Count == 0)
            {
                var assembly = results.CompiledAssembly;
                Type barType = assembly.GetType("bar");
                barType.GetMethod("Main").Invoke(null, null);
            }*/

            Console.ReadKey();
        }
    }
}
