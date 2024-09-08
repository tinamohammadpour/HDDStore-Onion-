using App.Domain.Entities.BaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Faqs
{
    public class Faq:BaseEntity
    {

        [Display(Name = "دسته بندی")]
        public int FaqCategoryId { get; set; }

        [Display(Name = "پرسش")]
        public string Question { get; set; }

        [Display(Name = "پاسخ")]
        public string Answer { get; set; }

        [Display(Name = "کلید دسترسی")]
        public string? ShortKey { get; set; }


        [ForeignKey(nameof(FaqCategoryId))]
        public FaqCategory FaqCategory { get; set; }



    }
}
