using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Entites;
using TodoApp.Core.Interfaces;
using TodoApp.Infrastructure.Data;

namespace TodoApp.Infrastructure.Repositories
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private readonly ApplicationContext _context;

        public ToDoItemRepository(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<ToDoItem>> GetAllAsync()
            => await _context.toDoItems.AsNoTracking().ToListAsync();


        public async Task<ToDoItem?> GetByIdAsync(int id)
            => await _context.toDoItems.FindAsync(id);
            
    
        public async Task AddAsync(ToDoItem toDoItem)
            => await _context.toDoItems.AddAsync(toDoItem);

        public async Task DeleteAsync(int id)
        {
            var item =await _context.toDoItems.FindAsync(id);
            if (item is not null)
            {
                _context.toDoItems.Remove(item);      
            }

        }
        
        public async Task UpdateAsync(int id)
        {
            var item = await _context.toDoItems.FindAsync(id);
            if (item is not null)
            {
                _context.toDoItems.Update(item);
            }

        }
    }
}
