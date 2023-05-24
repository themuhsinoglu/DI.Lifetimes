using SingletonScopedTransient.BusinessEngine.Interfaces;
using SingletonScopedTransient.BusinessEngine.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMySingletonService, MySingletonService>();
builder.Services.AddScoped<IMyScopedService, MyScopedService>();
builder.Services.AddTransient<IMyTransientService, MyTransientService>();
builder.Services.AddTransient<AllManagementService, AllManagementService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
