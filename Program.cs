using Infrastructure;
namespace NetficationApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddInfrastructureServices(builder.Configuration);
            var app = builder.Build();
            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}