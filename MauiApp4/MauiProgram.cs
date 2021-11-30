using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;

namespace MauiApp4
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers(handlers =>
				{
					// Register ALL handlers in the Xamarin Community Toolkit assembly
					//handlers.AddCompatibilityRenderers(typeof(Xamarin.CommunityToolkit.UI.Views.MediaElementRenderer).Assembly);
					handlers.AddCompatibilityRenderer(typeof(Xamarin.CommunityToolkit.UI.Views.Popup), typeof(Xamarin.CommunityToolkit.UI.Views.Popup));

				})
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			return builder.Build();
		}
	}
}