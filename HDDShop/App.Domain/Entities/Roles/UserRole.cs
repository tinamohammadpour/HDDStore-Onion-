using App.Domain.Entities.BaseData;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Roles
{
    public class UserRole : BaseEntity
    {
        [Display(Name = "کاربر")]
        public int UserId { get; set; }
        [Display(Name = "نقش")]
        public int RoleId { get; set; }

        #region MyRegion
        [ForeignKey(nameof(RoleId))]
        public Role Role { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        #endregion
    }
}
