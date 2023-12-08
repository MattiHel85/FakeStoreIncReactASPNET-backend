using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set;}
        public DateTime CreatedDate {get; set;}
        public DateTime UpdatedDate {get; set;}
    }
}