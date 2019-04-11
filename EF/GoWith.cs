using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class GoWith:Base
    {
        public virtual Invitation Invitation { get; set; }
        public string InitiateUserId { get; set; }

        public string Explain { get; set; }

    }
}
