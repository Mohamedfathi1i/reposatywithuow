using reposatywithuow.Contracts;
using reposatywithuow.Extensions;
using reposatywithuow.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IProduct, ProductRepository>();
// Add services to the container.
builder.Services.configureSqlContext(builder.Configuration);
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
