//builder'dan app'a kadar olan k�s�m gerekli servislerin eklendi�i, gerekli konfig�rasyonlar�n yap�ld��� yer.
using Day6_efcore1.Context;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //AutoMapper Third party k�t�phanesi i�in eklendi.

builder.Services.AddDbContext<BaseDbContext>();

//app'den ba�lay�p app.Run() metoduna kadar giden yer middleware'lara denk gelir.
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
