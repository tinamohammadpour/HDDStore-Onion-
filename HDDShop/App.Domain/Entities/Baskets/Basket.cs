using App.Domain.Entities.BaseData;
using App.Domain.Entities.Orders;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Baskets
{
    public class Basket : BaseEntity
    {
        [Display(Name = "سفارش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int OrderId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }

        [Display(Name = "تاریخ حذف خودکار محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime DeleteItemDate { get; set; }

        #region Relation
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
        #endregion
    }
}
