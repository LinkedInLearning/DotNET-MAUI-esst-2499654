using CommunityToolkit.Maui;
using ElVegetarianoFurio.Menu;
using ElVegetarianoFurio.Profile;
using Microsoft.Extensions.Logging;

namespace ElVegetarianoFurio;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("ShadowsIntoLight-Regular.ttf", "Shadows");
				fonts.AddFont("Sofia-Regular.ttf", "Sofia");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IProfileService, ProfileService>();
		builder.Services.AddTransient<ProfileViewModel>();
		builder.Services.AddTransient<ProfilePage>();
		builder.Services.AddSingleton<IPreferences>(Preferences.Default);
		builder.Services.AddSingleton<IMenuService, MenuService>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransientWithShellRoute<CategoriesPage, CategoriesViewModel>(nameof(CategoriesPage));
        return builder.Build();
	}
}
