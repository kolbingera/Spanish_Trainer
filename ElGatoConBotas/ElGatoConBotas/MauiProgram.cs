using ElGatoConBotas.Database;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using ElGatoConBotas.Domain.Interfaces;
using ElGatoConBotas.Domain.Entities;
using ElGatoConBotas.Services;



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
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:8080") });
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite("Data Source=C:\\Users\\kolbingera\\Desktop\\Spanish_Trainer\\ElGatoConBotas\\ElGatoConBotas\\wwwroot\\db\\SpanishVocabDb.db"));
            builder.Services.AddScoped<IVocabService, VocabServices>();
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
