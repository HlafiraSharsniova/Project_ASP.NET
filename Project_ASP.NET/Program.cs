using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Data;
using Project_ASP.NET.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
//Services configuration
builder.Services.AddScoped<IProceduresService, ProceduresService>();
builder.Services.AddScoped<IMastersService, MastersService>();
builder.Services.AddScoped<IClientsService, ClientsService>();
builder.Services.AddScoped<IReservationsService, ReservationsService>();

builder.Services.AddControllersWithViews();

//builder.Services.AddScoped<AppDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");//будет работать только в режиме отладки
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
}



app.UseHttpsRedirection();//переадресация

app.UseStaticFiles();//статические файлы,стили,картинки

app.UseRouting();//

app.UseAuthorization();//


app.MapControllerRoute(// отслеживание ЮРЛ адресов
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//Seed database
AppDbInitializer.Seed(app);

app.Run();

