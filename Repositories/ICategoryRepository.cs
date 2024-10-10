using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models;

namespace ManagementSystem.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task Delete(int id);
    }
}