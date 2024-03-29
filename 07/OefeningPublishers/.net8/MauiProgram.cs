﻿using Microsoft.Extensions.Logging;
using OefeningPublishers.ViewModels;
using OefeningPublishers.Views;

namespace OefeningPublishers
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
            builder.Services.AddSingleton<StoresPage>();
            builder.Services.AddSingleton<StoresViewModel>();

            builder.Services.AddSingleton<EmployeesPage>();
            builder.Services.AddSingleton<EmployeesViewModel>();

            return builder.Build();
        }
    }
}
