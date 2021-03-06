﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON.Database_Resources
{
    class JsonDB : IDB
    {
        private FileIO fio;
        private readonly string path = ConfigurationManager.AppSettings["JSON_DB_Path"];

        public string readAll()
        {
            if (fio == null)fio = new FileIO();
           return fio.readAll(path);
        }

        public bool write(string xmlTo)
        {
            if (fio == null) fio = new FileIO();
            return fio.write(path, xmlTo);
        }
    }
}
