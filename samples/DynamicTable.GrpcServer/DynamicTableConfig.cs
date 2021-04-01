using DynamicTable.Grpc;

namespace DynamicTable.GrpcServer
{
    public class DynamicTableConfig :IDynamicTableConfig
    {
        public bool SplitTable => true;
        
        public string GetSplitTableName(string tableName)
        {
            throw new System.NotImplementedException();
        }
    }
}