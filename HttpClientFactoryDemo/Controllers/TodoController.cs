using HttpClientFactoryDemo.Model.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Controllers
{
    public class TodoController : Controller
    {
        private readonly IToDoService _toDoService;

        public TodoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task<IActionResult> GetToDo(int id)
            => Ok(await _toDoService.GetToDo(id));
    }
}
