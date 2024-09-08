using App.Domain.Entities.BaseData;
using App.Domain.Entities.Orders;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Payment
{
    public class Payment : BaseEntity
    {

        [Display(Name = "سفارش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int OrderId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }

        [Display(Name = "شماره تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int TransactionNumber { get; set; }


        [Display(Name = "کد تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int TransactionHexCode { get; set; }


        [Display(Name = "تاریخ تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Display(Name = "مبلغ خرید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public long price { get; set; }

        [Display(Name = "کد وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int StatusCode { get; set; }


        [Display(Name = "وضعیت پرداخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Enums.PaymentResult PaymentResult { get; set; } = Enums.PaymentResult.Pending;

        #region Relation 
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        #endregion
    }

}
