using AnotherWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherWebAPI.Data
{
    public class NevermindStorage
    {
        public static List<Nevermind> neverminds = new List<Nevermind>()
        {
            new Nevermind(){id = 0, name = "foo" },
            new Nevermind(){id = 1, name = "bar" },
            new Nevermind(){id = 2, name = "baz" }
        };
    }
}
