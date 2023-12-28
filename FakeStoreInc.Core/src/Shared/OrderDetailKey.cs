using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Shared
{
    public class OrderDetailKey
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
    }
}