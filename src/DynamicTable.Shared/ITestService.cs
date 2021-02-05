using System.Collections.Generic;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace DynamicTable.Shared
{
    [Service]
    public interface ITestService
    {
        [Operation]
        IAsyncEnumerable<string> SubscribeAsync(CallContext context = default);
    }
}