using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using ElGatoConBotas.Database;
using ElGatoConBotas.Domain.Service;
using ElGatoConBotas.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

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
            // Add DbContext with SQLite connection string
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=C:\\Users\\kolbingera\\Desktop\\Spanish_Trainer\\ElGatoConBotas\\ElGatoConBotas\\wwwroot\\db\\SpanishVocabDb.db"));

            builder.Services.AddScoped<IVocabService, VocabService>();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
