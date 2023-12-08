using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeStoreInc.Core.src.Parameter
{
    public class GetAllParams
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
        public string Search { get; set; }
        public Guid CategoryId { get; set; }
    }
}