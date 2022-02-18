
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Dto
{
    public class IssueDto :BaseDto
    {
        public string Problem { get; set; }

        public string Description { get; set; }

        public int EmployeeID { get; set; }
    }
}
