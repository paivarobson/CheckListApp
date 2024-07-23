using Microsoft.Extensions.Logging;
using CheckListApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CheckListApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite($"Data Source=checklistapp.db"));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            SeedData.Initialize(services);
        }

        return app;
    }
}

