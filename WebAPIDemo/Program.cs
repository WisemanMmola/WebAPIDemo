using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Data;
var builder = WebApplication.CreateBuilder(args);

// Configure Services Container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Register DbContext with the dependency injection container
builder.Services.AddDbContext<ApiDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);


var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
