using Stystem.Collections.Generic;

namespace Claire.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Rating { get; set; }
        public string Review { get; set; }
        public int ClientsId { get; set; }
        public virtual Clients clients { get; set; }

    }
}