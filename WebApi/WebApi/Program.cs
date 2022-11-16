var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.Services.GetRequiredService<ILogger<Program>>().LogInformation(GitVersionInformationProvider.FullSemVer);
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
