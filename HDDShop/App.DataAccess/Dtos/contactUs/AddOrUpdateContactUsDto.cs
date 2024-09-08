using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.contactUs
{
    public class AddOrUpdateContactUsDto
    {

        [Display(Name = "نام کامل")]
        public string FullName { get; set; }

        [Display(Name = "شماره تلفن")]
        public string Phonenumber { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "شرح")]
        public string Description { get; set; }
    }
}
