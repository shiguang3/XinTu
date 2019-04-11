using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public abstract class Base
    {
        public long Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
    }
}
