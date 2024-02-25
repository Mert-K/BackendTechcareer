//builder'dan app'a kadar olan kýsým gerekli servislerin eklendiði, gerekli konfigürasyonlarýn yapýldýðý yer.
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

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); //AutoMapper Third party kütüphanesi için eklendi. IMapper interface'inin IOS kaydý için eklendi.

builder.Services.AddDbContext<BaseDbContext>(opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    });


// Dependency Injection LifeCycle
// AddSingleton -> Uygulama boyunca bellekte tek 1 tane instance tutar
// AddScoped -> Request response arasýnda yaþam süresi olan bir nesnenin instance'ýný tutar
// AddTransient -> Nesne ne zaman injection ile çaðýrýlýyorsa her çaðýrýldýðý yer için bir nesne bellekte tutar

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<PlayerService>(); //Sadece class new'lendi. Çünkü Controller'da interface olarak kullanýlmadý.







//app'den baþlayýp app.Run() metoduna kadar giden yer middleware'lara denk gelir.
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
