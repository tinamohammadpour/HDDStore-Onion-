using App.Domain.Entities.BaseData;
using App.Domain.Entities.Massages;
using App.Domain.Entities.Orders;
using App.Domain.Entities.Products;
using App.Domain.Entities.Roles;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace App.Domain.Entities.Users
{
    public class User : BaseEntity
    {


        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        public string UserName { get; set; }

        public DateTime BirthDay { get; set; } = DateTime.Now;


        [MaxLength(100)]
        public string? Email { get; set; }

        public string? Image { get; set; }

        [Required]
        [MaxLength(13)]
        [MinLength(11)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string? Description { get; set; }

        //public int SmsCodeId { get; set; }


        //[Required]
        //[MaxLength(4)]
        //public string Code { get; set; }

        #region MyRegion
        public ICollection<Product> Products { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public ICollection<SmsCode> SmsCodes { get; set; }
        public ICollection<UserToken> UserTokens { get; set; }
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}
