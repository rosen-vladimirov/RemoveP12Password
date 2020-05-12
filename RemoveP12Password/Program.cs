using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RemoveP12Password
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 3 || args.Contains("/?") || args.Contains("--help") || args.Contains("-h"))
            {
                Console.WriteLine("Usage: RemoveP12Password <infile> <current_password> <outfile>");
                return 1;
            }

            string infile = args[0];
            string outfile = args[2];
            string password = args[1];
            string outpassword = "";

            if (infile == outfile)
            {
                Console.WriteLine("Input and output file cannot be the same.");
                return 2;
            }

            Console.WriteLine(String.Format("Loading {0} with provided password.", infile));
            X509Certificate2 cert = new X509Certificate2(infile, password, X509KeyStorageFlags.Exportable);
            
            Console.WriteLine(String.Format("Converting {0} to {1} and remove the password.", infile, outfile));
            File.WriteAllBytes(outfile, cert.Export(X509ContentType.Pfx, outpassword));
            
            Console.WriteLine(String.Format("Convertion of {0} to {1} completed. Now the {1} does not have password.", infile, outfile));
            return 0;
        }
    }
}
