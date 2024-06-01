using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaxDepartment: Entity<int>
    {
        public string Code { get; set; }
        public string City { get; set; }
        public string Name { get; set; }

        public TaxDepartment()
        {
            Code = string.Empty;
            City = string.Empty;
            Name = string.Empty;
        }

        public TaxDepartment(string code, string city, string name)
        {
            Code = code;
            City = city;
            Name = name;
        }
    }
}
