using DynamicTable.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace DynamicTable.Components
{
    public partial class HeadCell
    {
        [Parameter]
        public ColumnConfig Column { get; set; }
    }
}