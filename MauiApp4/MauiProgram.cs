using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp4.Data;
using Syncfusion.Blazor;

namespace MauiApp4;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });

		return builder.Build();
	}
}
