using App.DataAccess.Dtos.contactUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.contactUs
{
    public interface IContactService
    {
        Task<IEnumerable<ContactUsDto>> GetAll();
        Task<ContactUsDto> GetById(int id);
        Task Add(AddOrUpdateContactUsDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateContactUsDto model);
    }
}
