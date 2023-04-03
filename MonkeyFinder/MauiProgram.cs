﻿using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder;

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

        RegistrarServicios(builder);

        return builder.Build();
    }

    private static void RegistrarServicios(MauiAppBuilder builder)
    {
        //Services
        builder.Services.AddSingleton<MonkeyService>();

        //ViewModels
        builder.Services.AddSingleton<MonkeyViewModel>();
        builder.Services.AddTransient<MonkeyDetailViewModel>();

        //Page
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailPage>();
    }
}
