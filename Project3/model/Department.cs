using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project3.model
{
   public  class Department
    {
        public Guid  Id { get; set; } 
        public String  Name { get; set; }

        public override string ToString()
        {
            return Name + " (" + Id.ToString().Substring(25) + ")";
        }
    }
}
