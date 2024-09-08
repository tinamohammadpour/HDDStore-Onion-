using App.DataAccess.Dtos.payRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.payRules
{
    public interface IpayRulesService
    {
        Task<IEnumerable<payRulesDto>> GetAll();
        Task<payRulesDto> GeyById(int id);
        Task Add(AddOrUpdatePayRulesDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdatePayRulesDto model);
    }
}
