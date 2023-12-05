var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                //for your Razor Pages.
                //options.RootDirectory = "/Pages";

                //Use the below line to change the default
                //"landing page" of the application.
                options.Conventions.AddPageRoute("/Home/Index", "");
                //options.Conventions.AddPageRoute("/Privacy", "");
                options.Conventions.AddAreaPageRoute("AdminArea", "/AdminArea/Index", "login");
            }
         );

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Account}/{action=Login}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "AdminArea",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "UserArea",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//});
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapRazorPages();
//    endpoints.MapDefaultControllerRoute();
//});

app.Run();
