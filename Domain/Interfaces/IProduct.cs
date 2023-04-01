using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IProduct
    {
        Guid ProductId { get; set; }

        string? ProductName { get; set; }

        int Amount { get; set; }

        Guid CategoryId { get; set; }

    }
}
