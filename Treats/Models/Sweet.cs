using System.Collections.Generic;

namespace Treats.Models
{
public class Sweet
    {
        public Sweet()
        {
            this.JoinEntities = new HashSet<SweetFlavor>();
        }

        public int SweetId { get; set; }
        public string SweetName { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<SweetFlavor> JoinEntities { get; set; }
    }
}