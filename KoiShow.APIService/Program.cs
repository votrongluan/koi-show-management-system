using KoiShow.Data.Models;
using KoiShow.Service;
using KoiShow.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<FA24_SE1716_PRN231_G2_KoiShowContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()   // Allow any origin
                  .AllowAnyMethod()   // Allow any HTTP method (GET, POST, etc.)
                  .AllowAnyHeader();  // Allow any headers (Authorization, etc.)
        }
    );
});

builder.Services.AddScoped<ContestResultService>();
builder.Services.AddScoped<ContestService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
