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
        Task<ToDoItem> GetByIdAsync(int id);
        Task<IEnumerable<ToDoItem>> GetAllAsync();
        Task Add(ToDoItem toDoItem);
        Task Update(int id);
        Task Delete(int id);
    }
}
