var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();


/*
    DAL Klasoru : Data Access Layer (veri erisim katman�). Entities ve Context bulunur. Codefirst yaklas�m� ile devam edecegiz.

    Controller da backend kodlar� yaz�l�r.
*/
