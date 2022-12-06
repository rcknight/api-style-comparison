using Microsoft.AspNetCore.Mvc;

namespace controllers.Api.Tasks;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskRepository _repo;
    
    public TasksController(ITaskRepository repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public IEnumerable<Task> Get()
    {
        return _repo.GetAll();
    }

    [HttpGet("{id:guid}")]
    public Task? GetById(Guid id)
    {
        return _repo.Get(id);
    }
}