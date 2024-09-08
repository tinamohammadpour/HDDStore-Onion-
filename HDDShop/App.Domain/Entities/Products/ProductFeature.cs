using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Products
{
    public class ProductFeature:BaseEntity
    {


        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Key { get; set; }


        [Display(Name = "ارزش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string Value { get; set; }


        [Display(Name = "کپشن")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string Caption { get; set; }

        [Display(Name = "محصول")]
        public int ProductId { get; set; }



        #region MyRegion
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        #endregion

    }
}
