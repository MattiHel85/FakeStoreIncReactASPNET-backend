using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.Service;
using FakeStoreInc.Business.src.Shared;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.WebAPI.src.Database;
using FakeStoreInc.WebAPI.src.Repository;
using AutoMapper;
using FakeStoreInc.WebAPI.src.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc(options =>
{
    options.SuppressAsyncSuffixInActionNames = false;
});

// declare services
builder.Services
.AddScoped<IUserService, UserService>() // Create instance of class UserService
.AddScoped<ITokenService, TokenService>()
.AddScoped<IProductService, ProductService>()
.AddScoped<ICategoryService, CategoryService>()
.AddScoped<IOrderService, OrderService>()
.AddScoped<IOrderDetailService, OrderDetailService>()
.AddScoped<IAuthService, AuthService>()
.AddScoped<IUserRepo, UserRepo>()
.AddScoped<IProductRepo, ProductRepo>()
.AddScoped<ICategoryRepo, CategoryRepo>()
.AddScoped<IOrderRepo, OrderRepo>()
.AddScoped<IOrderDetailRepo, OrderDetailRepo>();

// builder.Services.AddScoped<IAuthorizationHandler, CheckUserHandler>();
// builder.Services.AddScoped<CheckUserRequirement>(provider => new CheckUserRequirement(""));

// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
//     options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidIssuer = builder.Configuration["Jwt:Issuer"],
//             ValidAudience = builder.Configuration["Jwt:Audience"],
//             IssuerSigningKey = new SymmetricSecurityKey
//             (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),
//             ValidateIssuer = true,
//             ValidateAudience = true,
//             ValidateLifetime = true,
//             ValidateIssuerSigningKey = true
//         };
//     }
// );

builder
  .Services
  .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddJwtBearer(o =>
  {
    o.TokenValidationParameters = new TokenValidationParameters
    {
      ValidIssuer = builder.Configuration["Jwt:Issuer" ?? "Default Issuer"],
      ValidAudience = builder.Configuration["Jwt:Audience" ?? "Default Audience"],
      IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"] ?? "Default Key")),
      ValidateIssuer = true,
      ValidateAudience = true,
      ValidateLifetime = true,
      ValidateIssuerSigningKey = true
    };
  });

// builder.Services.AddAuthorization(policy => {
//     policy.AddPolicy("CheckUser", policy => policy.RequireAuthenticatedUser());
//     policy.AddPolicy("CheckUser", policy => policy.AddRequirements(new CheckUserRequirement("")));
// });


// Add database context service
builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql());

// add automapper dependency injection
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);


// build app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// add middlewares
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// run app
app.Run();