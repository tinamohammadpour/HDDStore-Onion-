using App.DataAccess.Dtos.faqs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.faqs
{
    public interface IFaqCategoryService
    {
        Task<IEnumerable<FaqCategoryDto>> GetAll();
        Task<FaqCategoryDto> GetById(int id);
        Task Add(AddOrUpdateFaqCategoryDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateFaqCategoryDto model);
    }
}
