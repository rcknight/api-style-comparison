namespace minimal.Api.Tasks;

public class TasksApi
{
    public static void MapEndpoints(RouteGroupBuilder routes)
    {
        routes.MapGet("/", GetAll);
        routes.MapGet("/{id:guid}", GetById);
    }

    private static IEnumerable<Task> GetAll(ITaskRepository repo)
    {
        return repo.GetAll();
    }

    private static Task? GetById(ITaskRepository repo, Guid id)
    {
        return repo.Get(id);
    }
}