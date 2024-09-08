using App.DataAccess.Dtos.faqs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.faqs
{
    public interface IFaqService
    {
        Task<IEnumerable<FaqDto>> GetAll();
        Task<FaqDto> GetById(int id);
        Task Add(AddOrUpdateFaqDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateFaqDto model);
    }
}
