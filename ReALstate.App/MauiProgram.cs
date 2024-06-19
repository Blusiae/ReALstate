using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using ReALstate.App.Data.Repositories;
using ReALstate.App.Data.Repositories.Interfaces;

namespace ReALstate.App
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

            builder.Services.AddTransient<IOfferRepository, OfferRepository>();
            builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
            builder.Services.AddTransient<IHouseRepository, HouseRepository>();
            builder.Services.AddTransient<IApartmentRepository, ApartmentRepository>();
            builder.Services.AddTransient<IAddressRepository, AddressRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
