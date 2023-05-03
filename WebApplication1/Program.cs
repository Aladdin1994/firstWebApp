var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern:"{controller}/{action}"
    );

 

//app.MapGet("/test", () =>
//{
//    return "P2143 lamfds"; 
//});

app.Run();
