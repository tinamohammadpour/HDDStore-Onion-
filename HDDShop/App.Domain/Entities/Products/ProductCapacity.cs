using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Products
{
    public class ProductCapacity:BaseEntity
    {
        [Display(Name = "مقدار")]
        public string Amount { get; set; }
        #region MyRegion
        public ICollection<Product> Products { get; set; }
        #endregion

    }
}
