using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DynamicTable.Shared;
using Grpc.Core;
using Microsoft.AspNetCore.Components;
using ProtoBuf.Grpc;

namespace DynamicTable
{
    public partial class Component1
    {
        private readonly List<string> _list = new();
        
        [Inject]
        private ExampleJsInterop JsInterop { get; set; }
        
        [Inject]
        private ITestService Service { get;set; }
    
        private async Task Test()
        {
            await JsInterop.Prompt("12314124");
        }

        private async Task TestGrpc()
        { 
            using var cancel = new CancellationTokenSource(TimeSpan.FromMilliseconds(500));
            var options = new CallOptions();
            try
            {
                await foreach (var item in Service.SubscribeAsync(new CallContext(options))
                    .WithCancellation(cancel.Token))
                {
                    _list.Add(item);
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine(e);
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}