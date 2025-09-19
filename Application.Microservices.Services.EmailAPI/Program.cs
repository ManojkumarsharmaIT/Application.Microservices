using Application.Microservices.Services.EmailAPI.Data;
using Application.Microservices.Services.EmailAPI.Extension;
using Application.Microservices.Services.EmailAPI.Messaging;
using Application.Microservices.Services.EmailAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// Register DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
builder.Services.AddSingleton(new EmailService(optionBuilder.Options));

builder.Services.AddSingleton<IAzureServiceBusConsumer, AzureServiceBusConsumer>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    if (!app.Environment.IsDevelopment())
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Email API");
        c.RoutePrefix = string.Empty;
    }
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseAzureServiceBusConsumer();
ApplyMigration();
app.Run();



// Apply Migration used to apply pending Migration to the database
void ApplyMigration()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        if (dbContext.Database.GetPendingMigrations().Count() > 0)
            dbContext.Database.Migrate();
    }
}
