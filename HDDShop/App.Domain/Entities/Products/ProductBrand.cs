using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Products
{
    public class ProductBrand:BaseEntity
    {


        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "عکس")]
        public string? image { get; set; }

        #region MyRegion
        public ICollection<Product> Products { get; set; }
        #endregion

    }
}
