using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Products
{
    public class ProductCategory: BaseEntity
    {

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "شرح")]
        public string? Description { get; set; }


        #region MyRegion

        public ICollection<Product> Products { get; set; }
        #endregion
    }
}
