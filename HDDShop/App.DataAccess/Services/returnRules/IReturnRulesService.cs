using App.DataAccess.Dtos.returnRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.returnRules
{
    public interface IReturnRulesService
    {
        Task<IEnumerable<returnRulesDto>> GetAll();
        Task<returnRulesDto> GetById(int id);
        Task Add(AddOrUpdatereturnRulesDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdatereturnRulesDto model);

    }
}
