using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PierresTreats.Models
{
  public class Flavor
  {

    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}