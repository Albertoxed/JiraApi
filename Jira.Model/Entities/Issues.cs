using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Models
{
    public class Issue : BaseEntity 
    {
      

        public string Problem { get; set; }

        public string Description { get; set; }

        public int EmployeeID { get; set; }

    }
}
