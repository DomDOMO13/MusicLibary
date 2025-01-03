namespace musicplayer;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using musicplayer.services;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        // using (var db = ServiceProvider.GetRequiredService<AppContext>()) {
        //     db.Database.EnsureCreated();

        //     var user = db.Users.ToList();
        // }


        Application.Run(ServiceProvider.GetRequiredService<MusicMenu>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppContext>();
                services.AddTransient<IUserService, UserService>();
                services.AddTransient<ILibraryService, LibraryService>();
                services.AddTransient<Form1>();
                services.AddTransient<MusicMenu>();
                services.AddTransient<AddMenu>();
                services.AddTransient<Search>();

            });
    }
}