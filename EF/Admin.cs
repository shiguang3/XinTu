using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Admin: Base
    {
        public string Name { get; set; }
        public string PhoneNum { get; set; }

        public string Pwd { get; set; }

        public byte LoginErrorNum { get; set; } = 0;
        public DateTime LastLoginErrorTime { get; set; } = DateTime.Now;

    }
}
