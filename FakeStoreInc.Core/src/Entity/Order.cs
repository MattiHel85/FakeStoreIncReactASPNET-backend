using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Entity
{
    public class Order : BaseEntity
    {
        public string OrderDate { get; set; }
        public enum Status { get; set; }
        public string PaymentMethod { get; set; }
        public int UserId { get; set;}
    }
}