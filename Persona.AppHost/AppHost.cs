var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Persona>("persona");

builder.Build().Run();
