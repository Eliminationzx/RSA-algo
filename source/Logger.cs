using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Rsa_algo
{
    class Logger
    {
        private bool _useLogs; // Use logs flag
        private string _path; // Log path
        private string _name; // Log name
        private long _size; // Log size
        public Logger(bool use, string path, string name, long size)
        {
            _useLogs = use;
            _path = path;
            _name = name;
            _size = size;
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
            int startFileName = path.LastIndexOf(@"\") + 1;
            string name = path.Substring(startFileName, path.LastIndexOf(".") + startFileName);
            bool append = false;
            FileInfo fi = new FileInfo(name);
            if (fi.Exists)
                append = fi.Length >= _size;
            StreamWriter file = new StreamWriter(path, append);
            file.WriteLine("[" + date + "]" + msg);
            file.Close();
            file.Dispose();
        }
    }
}
