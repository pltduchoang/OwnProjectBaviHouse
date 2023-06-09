﻿using BaviHouse.View;
using BaviHouse.ViewModel;
using Microsoft.Extensions.Logging;

namespace BaviHouse;

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


        builder.Services.AddSingleton<ApartmentPage>();
        builder.Services.AddSingleton<ApartmentViewModel>();

        builder.Services.AddSingleton<UtilityPage>();
        builder.Services.AddSingleton<UtilityVIewModel>();

		builder.Services.AddTransient<ApartmentDetailsPage>();
		builder.Services.AddTransient<ApartmentDetailsViewModel>();

		builder.Services.AddTransient<DetailsUpdatePage>();
		builder.Services.AddTransient<DetailsUpdateViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
