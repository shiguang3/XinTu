using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Invitation:Base
    {
        public string Content { get; set; }
        public string Head { get; set; }

        public string Intro { get; set; }
    }
}
