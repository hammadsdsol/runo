using runo.Models.Dtos;

namespace runo.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoDto>> GetAllTodosAsync();
        Task<TodoDto> GetTodoByIdAsync(int id);
        Task CreateTodoAsync(TodoDto Todo);
        Task UpdateTodoAsync(int id, TodoDto Todo);
        Task DeleteTodoAsync(int id);

    }
}
