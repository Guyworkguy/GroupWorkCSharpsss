using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrsMcave
{
    class Nameunb
    {
        public string Name { get; set; }
        public DateTime Total { get; set; }

        public Nameunb(string name, DateTime total)
        {
            Name = name;
            Total = total;
        }
    }
}
