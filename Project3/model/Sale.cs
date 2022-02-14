using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.model
{
   public class Sale
    {
        public Guid             Id { get; set; }
        public Guid              Id_Manager { get; set; }
        public Guid             Id_Product{ get; set; } 
        public int                 Cnt { get; set; }
        public DateTime      Moment { get; set; }

    }
}
