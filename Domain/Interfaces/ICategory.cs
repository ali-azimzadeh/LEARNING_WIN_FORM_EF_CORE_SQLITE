using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface ICategory
    {
        Guid CategoryId { get; set; }

        string? CategoryName { get; set; }

    }
}
