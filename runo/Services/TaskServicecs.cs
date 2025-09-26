using Microsoft.EntityFrameworkCore;
using runo.Data;
using runo.Models.Dtos;

namespace runo.Services
{
    public class TaskServicecs : ITaskService
    {
        private readonly ApplicationDbContext _context;
        public TaskServicecs(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext Context { get; }

        public Task CreateTaskAsync(TodoDto Todo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoDto>> GetAllTasksAsync()
        {
            var allTodos = await _context.Todos.ToListAsync();
            return allTodos.Select(todo => new TodoDto
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                Status = todo.Status
            });
        }

        public Task<TodoDto> GetTaskByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaskAsync(int id, TodoDto Todo)
        {
            throw new NotImplementedException();
        }
    }
}
