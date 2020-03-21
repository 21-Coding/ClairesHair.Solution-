using Stystem.Collections.Generic;

namespace Claire.Models
{
    public class Stylist
    {
       public Stylist()
       {
           this.Clients = new HashSet<Client>();
       }

       public int StylistId { get; set; }
       public string StylistName { get; set; }
       public string StylistCell { get; set; } 
       public string Skillset { get; set; }
       public virtual ICollection<Client> Clients { get; set; }

    }
}