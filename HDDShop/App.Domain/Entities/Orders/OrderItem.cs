using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Orders
{
    public class OrderItem:BaseEntity
    {

        [Display(Name = "سفارش")]
        public int OrderId { get; set; }

        [Display(Name = "قیمت کالا")]
        public int UnitPrice { get; set; }
        [Display(Name = "تعداد")]
        public int Amount { get; set; }

        [Display(Name = "محصول")]
        public int ProductId { get; set; }

        #region MyRegion
        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }
        #endregion
    }
}
