using App.DataAccess.Dtos.rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.rules
{
    public interface IRulesService
    {
        Task<IEnumerable<RulesDto>> GetAll();
        Task<RulesDto> GetById(int id);
        Task Add(AddOrUpdateRulesDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateRulesDto model);
    }
}
