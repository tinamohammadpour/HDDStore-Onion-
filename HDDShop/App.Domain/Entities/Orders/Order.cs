using App.Domain.Entities.BaseData;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }

        [Display(Name = "مبلغ کل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int SumPrice { get; set; }

        [Display(Name = "وضعیت سفارش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Enums.OrderStatus OrderStatus { get; set; }


        #region MyRegion
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        #endregion
    }
}
