using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiJira.Models
{
  public   interface IbaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
