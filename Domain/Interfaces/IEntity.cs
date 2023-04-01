using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    internal interface IEntity
    {
        bool IsDeleted { get; set; }

        bool IsActive { get; set; }
    }

}
