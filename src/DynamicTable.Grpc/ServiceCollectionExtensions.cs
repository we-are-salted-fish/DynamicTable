using DynamicTable.Grpc.Services;
using Microsoft.AspNetCore.Builder;
using ProtoBuf.Grpc.Server;


// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDynamicTableGrpc(this IServiceCollection services)
        {
            services.AddCodeFirstGrpc(config =>
            {
                config.ResponseCompressionLevel = System.IO.Compression.CompressionLevel.Optimal;
            });
            services.AddCodeFirstGrpcReflection();
            
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));
        }

        public static void UseDynamicTableGrpcServer(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<MyTimeService>()
                    .EnableGrpcWeb().RequireCors("AllowAll");
            });
        }
    }
}