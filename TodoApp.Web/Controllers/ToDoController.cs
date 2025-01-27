using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Core.Entites;
using TodoApp.Core.Interfaces;
using TodoApp.Web.ViewModels;

namespace TodoApp.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
 

        public ToDoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;


        }

        public async Task<IActionResult> Index()
        {
            var items = await _unitOfWork.ItemRepository.GetAllAsync();
            var viewModel = items.Select(item => new ToDoViewModel
            {
                Id = item.Id,
                Description = item.Description,
                IsCompleted = item.IsCompleted,
                Title = item.Title,
            }).ToList();
            return View(viewModel);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateToDoViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var item = new ToDoItem()
            {
                Title = ViewModel.Title,
                Description = ViewModel.Description,
            };
            await _unitOfWork.ItemRepository.AddAsync(item);
            await _unitOfWork.CommitAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
