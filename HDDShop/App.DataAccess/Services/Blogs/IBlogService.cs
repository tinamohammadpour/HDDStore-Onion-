using App.DataAccess.Dtos.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Blogs
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogDto>> GetAll();
        Task<BlogDto> GetById(int id);
        Task Add(AddorUpdateBlogDto model);
        Task Delete(int id);
        Task Update(int id, AddorUpdateBlogDto model);
    }
}
