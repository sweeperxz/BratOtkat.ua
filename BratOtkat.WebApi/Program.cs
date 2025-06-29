using BratOtkat.Core;
using BratOtkat.Domain.Repositories;
using BratOtkat.Infostructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.WebHost.UseUrls("http://0.0.0.0:80");
builder.Services.AddControllers();
builder.Services.AddScoped<IPositionRepository, PositionRepository>();
builder.Services.AddScoped<PositionService>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapOpenApi();
app.MapGet("/", ctx =>
{
    ctx.Response.Redirect("swagger/index.html");
    return Task.CompletedTask;
});


app.Run();