using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using YourNamespace.Services;
using Microsoft.Azure.Cosmos;
using Azure.AI.TextAnalytics;

namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Configure CosmosDB
            services.AddSingleton(s =>
            {
                CosmosClientOptions options = new CosmosClientOptions() { ApplicationRegion = Regions.WestUS };
                return new CosmosClient(Configuration["CosmosDb:ConnectionString"], options);
            });
            services.AddSingleton<IChatHistoryService, ChatHistoryService>();

            // Configure Azure OpenAI Service
            var credentials = new AzureKeyCredential(Configuration["OpenAI:ApiKey"]);
            var client = new TextAnalyticsClient(new Uri(Configuration["OpenAI:Endpoint"]), credentials);
            services.AddSingleton(client);

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
