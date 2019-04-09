using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Comment:Base
    {
        public long InitiateUserId { get; set; }

        public virtual User InitiateUser { get; set; }

        public long LastUserId { get; set; }

        public virtual User LastUser { get; set; }
        public long InvitationId { get; set; }
        public virtual Invitation Invitation { get; set; }

        public string Content { get; set; }
        
    }
}
