using System;
using System.Collections.Generic;
using System.Text;

namespace Cw2
{
    public class Studies
    {
        public string name { get; set; }
        public string mode { get; set; }
        public Studies(string n,string m)
        {
            name = n;
            mode = m;
        }
        public Studies()
        {
            name = "";
            mode = "";
        }
    }
}
