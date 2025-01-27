using System.ComponentModel.DataAnnotations;

namespace TodoApp.Web.ViewModels
{
    public class CreateToDoViewModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}
