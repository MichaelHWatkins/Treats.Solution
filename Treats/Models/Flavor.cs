using System.Collections.Generic;

namespace Treats.Models
{
public class Flavor
{
    public Flavor()
    {
        this.JoinEntities = new HashSet<SweetFlavor>();
    }

    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<SweetFlavor> JoinEntities { get; set; }
}
}