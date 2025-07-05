namespace practiceASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddHttpContextAccessor();


            // Configuring the session
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true; // restrict the client to access serverSide code
                options.Cookie.IsEssential = true; // override the browser setting to allow cookies

            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            // To enable session
            app.UseSession();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                // applying constraints on path variable
                pattern: "{controller=Home}/{action=Index}/{id:length(2)?}")
                //pattern: "{controller=Employees}/{action=Index}/{id:int?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
