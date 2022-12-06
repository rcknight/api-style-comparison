namespace controllers;

public class Task
{
    public Guid Id { get; set; }
    public DateTime DueDate { get; set; }
}

public class Patient
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public interface ITaskRepository
{
    List<Task> GetAll();
    Task? Get(Guid taskId);
}

public class TaskRepository : ITaskRepository
{
    private static readonly List<Task> Tasks = new ()
    {
        new Task { Id = Guid.NewGuid(), DueDate = DateTime.Today },
        new Task { Id = Guid.NewGuid(), DueDate = DateTime.Today.AddDays(1) },
        new Task { Id = Guid.NewGuid(), DueDate = DateTime.Today.AddDays(-1) },
    };

    public List<Task> GetAll()
    {
        return Tasks;
    }

    public Task? Get(Guid taskId)
    {
        return Tasks.FirstOrDefault(t => t.Id.Equals(taskId));
    }
}

public interface IPatientRepository
{
    List<Patient> GetAll();
    Patient? Get(Guid taskId);
}

public class PatientRepository : IPatientRepository
{
    private static readonly List<Patient> Patients = new()
    {
        new() { Id = Guid.NewGuid(), Name = "Joe Bloggs" },
        new() { Id = Guid.NewGuid(), Name = "John Smith" },
        new() { Id = Guid.NewGuid(), Name = "Alan Partridge" }
    };

    public List<Patient> GetAll()
    {
        return Patients;
    }

    public Patient? Get(Guid taskId)
    {
        return Patients.FirstOrDefault(p => p.Id.Equals(taskId));
    }
}