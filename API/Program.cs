using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); //vamos a ver como crear la bd usando getconnectionString
    
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();//cuando entra una solicitud https entonces este middleware le va a decir a nuestra solicitua cual endpoint api nesecita buscar

app.Run();
