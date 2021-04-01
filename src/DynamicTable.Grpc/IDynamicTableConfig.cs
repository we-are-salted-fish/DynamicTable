namespace DynamicTable.Grpc
{
    public interface IDynamicTableConfig
    {
         bool SplitTable { get; }

         string GetSplitTableName(string tableName);
    }
}