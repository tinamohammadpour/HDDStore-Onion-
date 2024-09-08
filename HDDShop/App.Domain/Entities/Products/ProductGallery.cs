using App.Domain.Entities.BaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Products
{
    public class ProductGallery:BaseEntity

    {


        [Display(Name = "محصول")]
        public int ProductId { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "تکست عکس")]
        public string? Alt { get; set; }

        #region MyRegion

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        #endregion
    }
}
