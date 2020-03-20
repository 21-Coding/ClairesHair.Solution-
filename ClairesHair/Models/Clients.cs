using System.Collection.Generic;

namespace Claire.Models
{
    public class Clients
    {
        public Clients()
        {
            this.Stylist = new Hashset<Stylist>();
        }

        public int ClientsId { get; set; }
        public string ClientsName { get; set; }
        public virtual ICollection<Stylist> Stylist { get; set; }
    }
}