using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mod = "qMBRpdYrAy5aMmo31NErUizh5sbweguSmh4wlK6uJEIDl+kwTlROnE34KOFExeTbJSX0WygPi+vWl0yNq7buIMUKpytossAAWut5khO3CQJxTk7G2gnEPNUUXHiExGgNrLzcSLv8YIlfVALhoRWyC67KOL+a+3taNq3h+BHeWhM=";
            string exp = "AQAB";
            var rsa = new Rsa();
            string text, publicKey;

            Console.WriteLine("Enter the text: ");
            text = Convert.ToString(Console.ReadLine());

            rsa.Modulus = mod;
            rsa.Exponent = exp;

            publicKey = rsa.Encrypt(text);

            Console.WriteLine("RSA Public Key: {0}", publicKey);
            Console.ReadKey();
        }
    }
}
