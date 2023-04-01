using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category : Entity, ICategory
    {
        #region Constructors
        public Category() : base()
        {
            CategoryId =
                System.Guid.NewGuid();
        }
        #endregion /Constructors

        #region Properties

        //*********************************************

        /// <summary>
        /// شناسه دسته بندی
        /// </summary>

        //  [Display(Name = "شناسه دسته بندی")]
        [Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.CategoryId))]

        [Key]

        public Guid CategoryId { get; set; }

        //*********************************************

        /// <summary>
        /// عنوان دسته بندی
        /// </summary>

        [Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.CategoryName))]

        [Required(ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.Required))]

        [StringLength(maximumLength: 30,
            ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.MaxLength))]
        public string? CategoryName { get; set; }

        //*********************************************


        #endregion /Properties
    }
}
