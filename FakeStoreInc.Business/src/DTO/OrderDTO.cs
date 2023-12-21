using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.DTO
{
    public class OrderReadDTO : BaseEntity
    {
        public Status OrderStatus { get; set;}
        public string? PaymentMethod { get; set;}
        public Guid UserId { get; set;}
        public ICollection<OrderItem>? OrderItems { get; set;}
    }

    public class OrderUpdateDTO
    {
        public Status OrderStatus { get; set;}
        public string? PaymentMethod { get; set;}
        public Guid UserId { get; set;}
        public ICollection<OrderItem>? OrderItems { get; set;}
    }

    public class OrderCreateDTO
    {
        public Status OrderStatus { get; set;} = Status.Pending;
        public string? PaymentMethod { get; set;}
        public Guid UserId { get; set;}
        public ICollection<OrderItem>? OrderItems { get; set;}
    }
}