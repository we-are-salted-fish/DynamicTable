using System;
using Microsoft.AspNetCore.Components;

namespace DynamicTable
{
    public partial class Column<TData>
    {
        [CascadingParameter(Name = "ItemType")]
        public Type ItemType { get; set; }
        
        [Parameter]
        public TData Field { get; set; }
        
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        

    }
}