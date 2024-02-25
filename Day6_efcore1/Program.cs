//builder'dan app'a kadar olan k�s�m gerekli servislerin eklendi�i, gerekli konfig�rasyonlar�n yap�ld��� yer.
using Day6_efcore1.Context;
using Day6_efcore1.Repositories.Abstract;
using Day6_efcore1.Repositories.Concrete;
using Day6_efcore1.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //AutoMapper Third party k�t�phanesi i�in eklendi. IMapper interface'inin IOS kayd� i�in eklendi.

builder.Services.AddDbContext<BaseDbContext>(opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    });


// Dependency Injection LifeCycle
// AddSingleton -> Uygulama boyunca bellekte tek 1 tane instance tutar
// AddScoped -> Request response aras�nda ya�am s�resi olan bir nesnenin instance'�n� tutar
// AddTransient -> Nesne ne zaman injection ile �a��r�l�yorsa her �a��r�ld��� yer i�in bir nesne bellekte tutar

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<PlayerService>(); //Sadece class new'lendi. ��nk� Controller'da interface olarak kullan�lmad�.







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
