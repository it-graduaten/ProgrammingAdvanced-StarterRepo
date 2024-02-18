using Microsoft.Extensions.Logging;
using Onderneming.mvvm.ViewModels;
using Onderneming.mvvm.Data.Repository;
using Onderneming.mvvm.Views;

namespace Onderneming.mvvm
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<WerknemerRepository>();

            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
