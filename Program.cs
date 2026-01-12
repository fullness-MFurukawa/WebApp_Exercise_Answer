using WebApp_Exercise_Answer.Presentations.Extensions;
using WebApp_Exercise_Answer.Presentations.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// 依存定義および依存性注入
builder.Services.SettingDependencyInjection(builder.Configuration); 

var app = builder.Build();
// IngternalExceptionをハンドリングするミドルウェアを有効化する
app.UseMiddleware<InternalExceptionLoggingMiddleware>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
