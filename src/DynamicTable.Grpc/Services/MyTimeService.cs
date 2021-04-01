using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DynamicTable.Shared;
using ProtoBuf.Grpc;

namespace DynamicTable.Grpc.Services
{
    public class MyTimeService: ITestService
    {
    
        public IAsyncEnumerable<string> SubscribeAsync(CallContext context = default)
            => SubscribeAsyncImpl(context.CancellationToken);

        private static async IAsyncEnumerable<string> SubscribeAsyncImpl([EnumeratorCancellation] CancellationToken cancel)
        {
            while (!cancel.IsCancellationRequested)
            {
                yield return Guid.NewGuid().ToString("N");
            }
        }
    }
}
