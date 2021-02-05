﻿using System;
using System.Net.Http;
using DynamicTable.Shared;
using Grpc.Net.Client.Web;
using ProtoBuf.Grpc.ClientFactory;


// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection UseGrpc(this IServiceCollection services, string address)
        {
            services
                .AddCodeFirstGrpcClient<ITestService>((provider, options) => { options.Address = new Uri(address); })
                .ConfigureHttpClient((provider, http) =>
                {
                    var state = provider.GetService<StateContainer>();
                    if (state?.IsLogin ?? false)
                    {
                        http.DefaultRequestHeaders.Add("Authorization", state.AccessToken);
                    }
                })
                .ConfigurePrimaryHttpMessageHandler(() =>
                    new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler()));
            return services;
        }
    }
}