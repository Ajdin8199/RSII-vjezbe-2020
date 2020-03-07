using System;
using System.Collections.Generic;

namespace eProdaja.Models
{
    public partial class JediniceMjere
    {
        public JediniceMjere()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int JedinicaMjereId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
