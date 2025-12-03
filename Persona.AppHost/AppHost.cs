var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Persona_Api>("persona");

builder.Build().Run();
