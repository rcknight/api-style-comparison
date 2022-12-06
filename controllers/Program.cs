using controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ITaskRepository, TaskRepository>();
builder.Services.AddSingleton<IPatientRepository, PatientRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();