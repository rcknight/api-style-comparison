using minimal;
using minimal.Api.Patients;
using minimal.Api.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITaskRepository, TaskRepository>();
builder.Services.AddSingleton<IPatientRepository, PatientRepository>();

var app = builder.Build();

var tasksApiRoot = app.MapGroup("/tasks");
TasksApi.MapEndpoints(tasksApiRoot);

var patientsApiRoot = app.MapGroup("/patients");
PatientsApi.MapEndpoints(patientsApiRoot);

app.Run();
