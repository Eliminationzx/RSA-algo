using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Rsa_algo
{
    class Program : ConstantProvider
    {
        static void outLog(string str, object args)
        {
            TextWriterTraceListener twtl = new TextWriterTraceListener(logPath, AppDomain.CurrentDomain.FriendlyName);
            twtl.Name = "RSALogger";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;
            Trace.Listeners.Add(twtl);
            Trace.AutoFlush = true;
            Trace.WriteLine(str + args);
        }
        static void rsaProcessor()
        {
            var rsa = new Rsa();
            rsa.Exponent = exp;
            rsa.Modulus = mod;
            Console.WriteLine("Enter the key: ");
            string key = rsa.Encrypt(Convert.ToString(Console.ReadLine()));
            outLog("[" + DateTime.Now + "] RSA Public Key: ", key);
            Console.WriteLine("Your public key is:{0}", key);
        }
        static void Main(string[] args)
        {
            rsaProcessor();
            Console.ReadKey();
        }
    }
}
