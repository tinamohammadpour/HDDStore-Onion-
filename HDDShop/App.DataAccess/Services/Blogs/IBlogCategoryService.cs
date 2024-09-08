using App.DataAccess.Dtos.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Services.Blogs
{
    public interface IBlogCategoryService
    {
        Task<IEnumerable<BlogCategoryDto>> GetAll();
        Task<BlogCategoryDto> GetById(int id);
        Task Add(AddOrUpdateBlogCategoryDto model);
        Task Delete(int id);
        Task Update(int id, AddOrUpdateBlogCategoryDto model);
    }
}
