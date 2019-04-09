using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class User:Base
    {
        public string HeadPortraitUrl { get; set; }
        public string Name { get; set; }

        public string PhoneNum { get; set; }

        public string Pwd { get; set; }
        public byte Sex { get; set; }

        public string Signature { get; set; }

        public byte LoginErrorNum { get; set; }
        public DateTime LastLoginErrorTime { get; set; }
    }
}
