using Microsoft.Extensions.Hosting;
using Persistance;
using Application;
using Microsoft.Extensions.DependencyInjection;

namespace FormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var mainForm = host.Services.GetRequiredService<MainForm>();
            System.Windows.Forms.Application.Run(mainForm);
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {

                services.AddPersistanceServices();
                services.AddApplicationServices();
                services.AddTransient<MainForm>();
                services.AddTransient<CurrentCreateForm>();
            });
            
    }
}