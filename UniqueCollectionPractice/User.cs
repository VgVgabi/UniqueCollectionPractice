using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace UniqueCollectionPractice
{
    public class User
    {
        public string Name { get; set; }
        public User(string name)
        {
            Name = name;
        }
        //
        public override string ToString()
        {
            return Name;
        }
    }
}
