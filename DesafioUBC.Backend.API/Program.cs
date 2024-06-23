using Microsoft.EntityFrameworkCore;
using DesafioUBC.Backend.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DesafioUBCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DesafioUBCBackendAPIContext' not found.")));

//builder.Services.AddDbContext<DesafioUBCContext>(options =>
//    options.UseInMemoryDatabase("DesafioUBC"));

//builder.Services.AddDbContext<DesafioUBCContext>(options =>
//    options.UseSqlite(connString));

//builder.Services.AddDbContext<DesafioUBCContext>(options =>/
//    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DesafioUBC;Trusted_Connection=True;"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
