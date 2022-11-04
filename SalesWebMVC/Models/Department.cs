using System;
using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator List<object>(Department v)
        {
            throw new NotImplementedException();
        }
    }
}
