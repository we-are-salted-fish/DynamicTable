namespace DynamicTable.Grpc
{
    public abstract class IDynamicTableConfig
    {
        public abstract bool SplitTable { get; }

        public abstract string GetSplitTableName(string tableName);
    }
}