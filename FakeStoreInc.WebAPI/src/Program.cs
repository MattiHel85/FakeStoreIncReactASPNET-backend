using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.Service;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.WebAPI.src.Database;
using FakeStoreInc.WebAPI.src.Repository;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// declare services
builder.Services.AddScoped<IUserService, UserService>(); // Create instance of class UserService
builder.Services.AddScoped<IUserRepo, UserRepo>();
// builder.Services.AddTransient();
// builder.Services.AddSingleton();

// add automapper dependency injection
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

// Add database context service
builder.Services.AddDbContext<DatabaseContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
