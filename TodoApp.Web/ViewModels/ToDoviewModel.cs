using System.ComponentModel.DataAnnotations;

namespace TodoApp.Web.ViewModels
{
    public class ToDoViewModel
    {

        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsCompleted { get; set; }
    }
}
