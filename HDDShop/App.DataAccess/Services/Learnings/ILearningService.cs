using App.DataAccess.Dtos.Learnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Learnings
{
    public interface ILearningService
    {
        Task<IEnumerable<LearningDto>> GetAll();
        Task<LearningDto> GetById(int id);
        Task Add(AddOrUpdateLearningDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateLearningDto model);
    }
}
