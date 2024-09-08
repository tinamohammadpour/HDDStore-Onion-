using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Products
{
    public class ProductColor:BaseEntity
    {
        [Display(Name = "رنگ")]
        public string Color { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }
        #region MyRegion
        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
