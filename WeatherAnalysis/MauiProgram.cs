﻿using Microsoft.Extensions.Logging;
using SampleBrowser.Maui.Base.Hosting;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.Toolkit.Hosting;



namespace WeatherAnalysis
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MauiMaterialAssets.ttf", "MaterialAssets");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-Regular.ttf", "Roboto");
                    fonts.AddFont("MauiSampleFontIcon.ttf", "MauiSampleFontIcon");
                });
            builder.ConfigureSampleBrowserBase();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
