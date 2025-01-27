using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entites;

namespace TodoApp.Core.Interfaces
{
    public interface IToDoItemRepository
    {
        Task<ToDoItem?> GetByIdAsync(int id);
        Task<IEnumerable<ToDoItem>> GetAllAsync();
        Task AddAsync(ToDoItem toDoItem);
        Task UpdateAsync(int id);
        Task DeleteAsync(int id);
    }
}
