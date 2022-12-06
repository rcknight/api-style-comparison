using Microsoft.AspNetCore.Mvc;

namespace controllers.Api.Patients;

[ApiController]
[Route("[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientRepository _repo;
    
    public PatientsController(IPatientRepository repo)
    {
        _repo = repo;
    }
    
    [HttpGet]
    public IEnumerable<Patient> Get()
    {
        return _repo.GetAll();
    }

    [HttpGet("{id:guid}")]
    public Patient? GetById(Guid id)
    {
        return _repo.Get(id);
    }
}