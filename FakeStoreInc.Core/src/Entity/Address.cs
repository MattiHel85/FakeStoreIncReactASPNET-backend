using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Entity
{
    public class Address : BaseEntity
    {
        public int HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? PostCode { get; set; }
    }
}