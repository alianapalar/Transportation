using Microsoft.EntityFrameworkCore;
using Transportation.BusinessLayer.Concrete;
using Transportation.BusinessLayer.Contracts;
using Transportation.DataAccessLayer.Concrete;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.UI.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<TransportationContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("mssqlConnection"),
                    b => b.MigrationsAssembly("Transportation.UI"));
                options.EnableSensitiveDataLogging(true);

            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
            })
            .AddEntityFrameworkStores<TransportationContext>();
        }
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IMessageRepository,MessageRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<ITeamMemberRepository, TeamMemberRepository>();
            services.AddScoped<ITransportTeamRepository, TransportTeamRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<ITransportRequestRepository, TransportRequestRepository>();
            services.AddScoped<IRequestTypeRepository, RequestTypeRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
        }
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IMessageService,MessageManager>();
            services.AddScoped<IReviewService, ReviewManager>();
            services.AddScoped<IDriverService, DriverManager>();
            services.AddScoped<ITeamMemberService, TeamMemberManager>();
            services.AddScoped<ITransportTeamService, TransportTeamManager>();
            services.AddScoped<IVehicleService, VehicleManager>();
            services.AddScoped<ITransportRequestService, TransportRequestManager>();
            services.AddScoped<IRequestTypeService,RequestTypeManager>();
            services.AddScoped<IReservationService, ReservationManager>();
        }
    }
}
