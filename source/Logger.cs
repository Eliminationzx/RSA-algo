﻿using System;
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
        private bool _useLogs;
        private string _path;
        private string _name;
        private long _size;
        public Logger(bool use, string path, string name, long size)
        {
            _useLogs = use;
            _path = path;
            _name = name;
            _size = size;
        }
        public void outError(string str, object args)
        {
            if (!_useLogs)
                return;

            string path = _path + _name;
            string msg = str + args;
            DateTime date = DateTime.Now;
            writeLine(path, msg, date);
        }
        private void writeLine(string path, string msg, DateTime date)
        {
            int startFileName = path.LastIndexOf(@"\") + 1;
            string name = path.Substring(startFileName, path.LastIndexOf(".") + startFileName);
            FileInfo fi = new FileInfo(name);
            StreamWriter file = new StreamWriter(path, fi.Length >= _size && fi.Exists);
            file.WriteLine("[" + date + "]" + msg);
            file.Close();
            file.Dispose();
        }
    }
}
