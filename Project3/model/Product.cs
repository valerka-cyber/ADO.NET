using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.model
{
   public class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        //типу Float в БД соответствует тип double
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Price} грн";
        }
    }
}
