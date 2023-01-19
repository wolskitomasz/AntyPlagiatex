using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntyPlagiatex
{
    public class JsonWynik
    {
        public JsonZdanie[] zdanie { get; set; }
    }

    public class JsonZdanie
    {
        public string tekst { get; set; }
        public JsonDane[] items { get; set; }

    }

    public class JsonDane
    {
        public string title { get; set; }
        public string link { get; set; }
        public string snippet { get; set; }
        public int test1 { get; set; }
        public int test2 { get; set; }
    }

}
