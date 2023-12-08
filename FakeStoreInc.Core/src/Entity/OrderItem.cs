using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Entity
{
    public class OrderItem : BaseEntity
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal PaymentMethod { get; set; }
        public int OrderId { get; set;}
        public int ProductId { get; set;}
    }
}