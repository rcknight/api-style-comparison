namespace minimal.Api.Patients;

public class PatientsApi
{
    public static void MapEndpoints(RouteGroupBuilder routes)
    {
        routes.MapGet("/", GetAll);
        routes.MapGet("/{id:guid}", GetById);
    }

    private static IEnumerable<Patient> GetAll(IPatientRepository repo)
    {
        return repo.GetAll();
    }

    private static Patient? GetById(IPatientRepository repo, Guid id)
    {
        return repo.Get(id);
    }
}