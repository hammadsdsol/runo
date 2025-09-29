using AutoMapper;
using Microsoft.EntityFrameworkCore;
using runo.Data;
using runo.Models.Dtos;

namespace runo.Services
{
    public class TodoService : ITodoService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public TodoService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;

        }
        public async Task CreateTodoAsync(TodoDto Todo)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTodoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoDto>> GetAllTodosAsync()
        {
            var todos = await _context.Todos.ToListAsync();
            return _mapper.Map<List<TodoDto>>(todos);
        }

        public async Task<TodoDto> GetTodoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTodoAsync(int id, TodoDto Todo)
        {
            throw new NotImplementedException();
        }
    }
}
