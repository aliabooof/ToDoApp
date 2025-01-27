using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IToDoItemRepository ItemRepository { get; }
        Task<int> CommitAsync();
    }
}
