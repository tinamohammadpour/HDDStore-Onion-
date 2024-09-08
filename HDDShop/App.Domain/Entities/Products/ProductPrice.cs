using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Products
{
    public class ProductPrice:BaseEntity
    {
        [Display(Name = "قیمت خرید")]
        public int BuyPrice { get; set; }

        [Display(Name = "قیمت فروش")]
        public int SalePrice { get; set; }
        [Display(Name = "قیمت فروش به همکار")]
        public int ColeagugePrice { get; set; }

        [Display(Name = "سود")]
        public int Benefit { get; set; }

        [Display(Name = "محصول")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
