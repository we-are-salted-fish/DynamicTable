using DynamicTable.Grpc;

namespace DynamicTable.GrpcServer
{
    public abstract class DynamicTableConfig :IDynamicTableConfig
    {
        public override bool SplitTable => true;
        
        public override string GetSplitTableName(string tableName)
        {
            throw new System.NotImplementedException();
        }
    }
}