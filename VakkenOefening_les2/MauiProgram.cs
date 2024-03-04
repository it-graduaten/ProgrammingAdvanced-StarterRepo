using Microsoft.Extensions.Logging;

namespace VakkenOefening
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
                    fonts.AddFont("TMCandor-Headline.otf", "TitelFont");
                    fonts.AddFont("TMCandor-Regular.otf", "DetailFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
