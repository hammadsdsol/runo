using runo.Models.Dtos;

namespace runo.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TodoDto>> GetAllTasksAsync();
        Task<TodoDto> GetTaskByIdAsync(int id);
        Task CreateTaskAsync(TodoDto Todo);
        Task UpdateTaskAsync(int id, TodoDto Todo);
        Task DeleteTaskAsync(int id);

    }
}
