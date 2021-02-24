using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "p@55w0rd";
            string hashValue = "39f13d60b3f6fbe0ba1636b0a9283c50".ToUpper();
            // Creates an instance of the default implementation of the MD5 hash algorithm.
            
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(source);
                Console.WriteLine(sourceBytes);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                Console.WriteLine(hashBytes);

                // Convert hash byte array to string
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                // Output the MD5 hash
                Console.WriteLine("The MD5 hash of " + source + " is: " + hash);

                if (hash == hashValue) Console.WriteLine("Valid password!");
                else Console.WriteLine("Invalid password!");
            }


            
        }
    }
}
