using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Entity : object, IEntity
    {
        public Entity() : base()
        {
        }

        //*********************************************

        /// <summary>
        /// وضعیت
        /// </summary>

        [Display(ResourceType = typeof(Resources.DataDictionary),
               Name = nameof(Resources.DataDictionary.IsActive))]

        public bool IsActive { get; set; }

        //*********************************************

        /// <summary>
        /// حذف شده
        /// </summary>

        [Display(ResourceType = typeof(Resources.DataDictionary),
           Name = nameof(Resources.DataDictionary.IsDeleted))]
        public bool IsDeleted { get; set; }

    }
}
