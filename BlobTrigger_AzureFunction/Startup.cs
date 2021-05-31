using BlobTrigger_AzureFunction.Models;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(BlobTrigger_AzureFunction.Startup))]

namespace BlobTrigger_AzureFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = "Data Source=N-20RJPF2CFK06\\SQLEXPRESS;Integrated Security=true;Database=FileUpload"; //"Data Source= Server name;Integrated Security=true;Database=DatabaseName"
            builder.Services.AddDbContext<AppDbContext>(
                options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
        }
    }
}
