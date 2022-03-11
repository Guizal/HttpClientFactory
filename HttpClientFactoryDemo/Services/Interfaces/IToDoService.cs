using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Model.Interfaces
{
    public interface IToDoService
    {
        Task<TodoModel> GetToDo(int id);
    }
}
