using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.model
{
   public  class Manager
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String SecName { get; set; }
        public Guid? Id_main_dep { get; set; }
        public Guid? Id_sec_dep { get; set; }
        public Guid? Id_chief { get; set; }

        public override string ToString()
        {
            return $"  {Surname} {Name.Substring(0,1)}. {SecName.Substring(0, 1)}. ";
        }
     
    }
}
