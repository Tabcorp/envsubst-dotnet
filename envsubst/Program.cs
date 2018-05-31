using System;
using System.IO;

namespace EnvSubSt
{
	/// <summary>
    /// Environment variables substitution in C# for .NET
	/// 
	/// This tool will do in-place replacement for environment variables in the given file.
	/// The environment variable format is %NAME% following Windows convention
	/// 
    /// </summary>
	class EnvSubSt
    {
        private static int FailedExitCode = 1;

        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: envsubst <file>");
                Environment.Exit(FailedExitCode);
            }

            string file = args[0];

            try
            {
                string origin = File.ReadAllText(file);
                string output = Environment.ExpandEnvironmentVariables(origin);

                File.WriteAllText(file, output);
                Console.WriteLine(output);

            }
            catch (Exception e)
            {
                Console.WriteLine("Failed: {0}", e.Message);
                Environment.Exit(FailedExitCode);
            }
        }
    }
}
