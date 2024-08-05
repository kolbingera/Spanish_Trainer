using ElGatoConBotas.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;


namespace ElGatoConBotas
{
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=C:\\Users\\kolbingera\\Desktop\\Spanish_Trainer\\ElGatoConBotas\\ElGatoConBotas\\wwwroot\\db\\SpanishVocabDb.db"));
            var app = builder.Build();
            // Migrate Database
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<AppDbContext>();
                dbContext.Database.Migrate();
            }

#if DEBUG
#endif

            return builder.Build();
        }
    }
}
