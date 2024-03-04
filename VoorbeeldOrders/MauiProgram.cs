using Microsoft.Extensions.Logging;
using VoorbeeldOrders.ViewModels;
using VoorbeeldOrders.Views;

namespace VoorbeeldOrders
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
            builder.Services.AddSingleton<WerknemersPage>();
            builder.Services.AddSingleton<WerknemersViewModel>();

            builder.Services.AddSingleton<OrdersPage>();
            builder.Services.AddSingleton<OrdersViewModel>();

            return builder.Build();
        }
    }
}
