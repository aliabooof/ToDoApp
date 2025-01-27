using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Core.Interfaces;

namespace TodoApp.Infrastructure.Data
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public IToDoItemRepository ItemRepository { get; }

        public UnitOfWork(ApplicationContext context , IToDoItemRepository itemRepository)
        {
            _context = context;
            ItemRepository = itemRepository;
        }


        public async Task<int> CommitAsync()
            => await _context.SaveChangesAsync();
        public async void Dispose()
        => await _context.DisposeAsync();
    }
}
