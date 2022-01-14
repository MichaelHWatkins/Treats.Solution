namespace Treats.Models
{
  public class SweetFlavor
  {       
    public int SweetFlavorId { get; set; }
    public int SweetId { get; set; }
    public int FlavorId { get; set; }
    public virtual Sweet Sweet { get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}