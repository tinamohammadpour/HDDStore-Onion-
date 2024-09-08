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
    public class Product  : BaseEntity
    {


        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name ="نام انگلیسی")]
        public string EnName { get; set; }
        [Display(Name = "عکس")]
        public string? Image { get; set; }


        [Display(Name = "دسته بندی کالا")]
        public int ProductCategoryId { get; set; }
        [Display(Name = "رنگ کالا")]
        public int ProductColorId { get; set; }
        [Display(Name = "قیمت کالا")]
        public int ProductPriceId { get; set; }
        [Display(Name = "ظرفیت")]
        public int ProductCapacityId { get; set; }
        [Display(Name = "برند")]
        public int ProductBrandId { get; set; }


        [Display(Name = "لینک کوتاه")]
        public string? ShortLink { get; set; }
        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }

        [Display(Name="شرح")]
        public string Description { get; set; }

        #region MyRegion

        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategory ProductCategory { get; set; }
        
        [ForeignKey(nameof(ProductColorId))]
        public ProductColor ProductColor { get; set; }

        [ForeignKey(nameof(ProductCapacityId))]
        public ProductCapacity ProductCapacity { get; set; }

        [ForeignKey(nameof(ProductBrandId))]
        public ProductBrand ProductBrand { get; set; }



        public ICollection<ProductGallery> ProductGalleries { get; set; }

        [ForeignKey(nameof(ProductPriceId))]
        public ProductPrice ProductPrice { get; set; }

        public ICollection<ProductFeature> ProductFeatures { get; set; }
        #endregion


    }
}
