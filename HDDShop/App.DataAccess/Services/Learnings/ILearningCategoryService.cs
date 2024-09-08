using App.DataAccess.Dtos.Learnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Learnings
{
    public interface ILearningCategoryService
    {
        Task<IEnumerable<LearningCategoryDto>> GetAll();
        Task<LearningCategoryDto> GetById(int id);
        Task Add(AddOrUpdateLearningCategoryDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateLearningCategoryDto model);
    }
}
