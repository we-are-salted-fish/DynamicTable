using System.Collections.Generic;

namespace DynamicTable.Models
{
    public class TableConfig
    {
        public string Table { get; set; }
        
        public List<ColumnConfig> Columns { get; set; }
    }
}