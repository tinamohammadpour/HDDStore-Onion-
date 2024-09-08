using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Learnings
{
    public class LearningCategory : BaseEntity
    {

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }

        [Display(Name = "شرح")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string? Discription { get; set; }


        [Display(Name = "عکس")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]

        public string? Image { get; set; }
        #region Relation 
        public ICollection<Learning> Learnings { get; set; }
        #endregion
    }
}
