using App.DataAccess.Dtos.Abouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Abouts
{
    public interface IAboutService
    {
        Task<IEnumerable<AboutDto>> GetAll();
        Task<AboutDto> GetById(int id);
        Task Add(AddOrUpdateAboutDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateAboutDto model);
    }
}
