using System;
using System.Diagnostics;
using System.IO;

namespace Rsa_algo
{
    class Logger
    {
        private bool _useLogs; // Use logs flag
        private string _path; // Log path
        private string _name; // Log name
        public Logger(bool use, string path, string name)
        {
            _useLogs = use;
            _path = path;
            _name = name;
        }
        public void outError(string str, object args)
        {
            if (_useLogs)
            {
                string path = _path + _name;
                string msg = str + args;
                DateTime date = DateTime.Now;
                writeLine(path, msg, date);
            }
        }
        private void writeLine(string path, string msg, DateTime date)
        {
            StreamWriter file = new StreamWriter(path, false);
            file.WriteLine("[" + date + "]" + msg);
            file.Close();
            file.Dispose();
        }
    }
}
