using System.Collections.Generic;
using DynamicTable.Shared.Models;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace DynamicTable.Shared
{
    [Service]
    public interface IDynamicTableDataService
    {
        [Operation]
        IAsyncEnumerable<string> LoadDataAsync(TableConfig table, CallContext context = default);
    }
}