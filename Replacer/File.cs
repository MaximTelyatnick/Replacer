using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacer
{
    public class File
    {
        public string Path { get; set; }
        public bool Check { get; set; }


        public File()
        {
            Check = false;
        }
    }
}
