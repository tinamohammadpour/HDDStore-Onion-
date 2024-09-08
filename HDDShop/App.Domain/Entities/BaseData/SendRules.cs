using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.BaseData
{
    public class SendRules:BaseEntity
    {
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "شرح")]
        public string Description { get; set; }
    }
}
