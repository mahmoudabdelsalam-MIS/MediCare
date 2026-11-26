using MediCare.BLL;

var builder = WebApplication.CreateBuilder(args);

// إضافة خدمات الـ MVC
builder.Services.AddControllersWithViews();

// ربط الداتابيز وطبقات المشروع (دي بديلة سطر AddDbContext)
builder.Services.AddBusinessLogicLayer(builder.Configuration);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();