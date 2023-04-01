using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product : Entity, IProduct
    {
        #region Constructors
        public Product() : base()
        {
            ProductId = 
                System.Guid.NewGuid();
        }
        #endregion /Constructors

        #region Properties

        //*********************************************

        /// <summary>
        /// شناسه محصول
        /// </summary>
        /// 
        [Display(ResourceType = typeof(Resources.DataDictionary),
           Name = nameof(Resources.DataDictionary.ProductId))]

        [System.ComponentModel.DataAnnotations.Key]
        public Guid ProductId { get; set; }

        //*********************************************

        /// <summary>
        /// نام محصول
        /// </summary>
        
        [Display(ResourceType = typeof(Resources.DataDictionary),
          Name = nameof(Resources.DataDictionary.ProductName))]

        [StringLength(maximumLength: 50,
            ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.MaxLength))]

        [MinLength(length: 5,
            ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.MinLength))]

        [Required(ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.Required))]
        public string? ProductName { get; set; }

        //*********************************************

        /// <summary>
        /// قیمت محصول
        /// </summary>

        [Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Amount))]

        [Range(minimum:10_000,maximum:1_000_000,
            ErrorMessageResourceType = typeof(Resources.Messages.ValidationMessages),
            ErrorMessageResourceName = nameof(Resources.Messages.ValidationMessages.Range))]
        public int Amount { get; set; }

        //*********************************************

        /// <summary>
        /// شناسه دسته بندی
        /// </summary>

        [Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.CategoryId))]

        [Required]

        public Guid CategoryId { get; set; }

        //*********************************************

      

        #endregion /Properties
    }
}
