using Microsoft.Extensions.Logging;
using Sistema.Cepillado.Dominio.Interfaces;
using Sistema.Cepillado.Infraestructura.Repositorios;
using Sistema.Cepillado.Aplicacion.Servicios;
using Sistema.Cepillado.Infraestructura.DB;




namespace Sistema.Cepillado.Presentacion
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

            // Add services to the container.
            builder.Services.AddScoped <IRepositorioPatronReferencia,RepositorioPatronReferencia>();
            builder.Services.AddScoped <IRepositorioTutor,RepositorioTutor>();
            builder.Services.AddScoped <IRepositorioTipoCepillado,RepositorioTipoCepillado>();
            builder.Services.AddScoped <IRepositorioSesion,RepositorioSesion>();
            builder.Services.AddScoped <IServicioTutores,ServicioTutores>();
            builder.Services.AddScoped <IServicioPerfilNino,ServicioPerfilNino>();
			builder.Services.AddScoped<IDBManager>(dbm => {
				 string ubicacion = "./DB/db.db";
				
                
				string password =  "SFI2025";

                return new DBManager(ubicacion, password);

			});
            ;
            //builder.Services.AddScoped <IDBManager, DBManager>();
            
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
