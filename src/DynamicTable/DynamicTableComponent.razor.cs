using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DynamicTable.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace DynamicTable
{
    public partial class DynamicTableComponent<TItem>
    { 
        private static readonly TItem _fieldModel = (TItem)RuntimeHelpers.GetUninitializedObject(typeof(TItem));
        
        private IEnumerable<TItem> _dataSource;
        
        [Parameter]
        public IEnumerable<TItem> DataSource
        {
            get => _dataSource;
            set => _dataSource = value ?? Enumerable.Empty<TItem>();
        }
        
        [Parameter]
        public RenderFragment TableHeader { get; set; }

        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; }

        [Parameter]
        public IReadOnlyList<TItem> Items { get; set; }
        
        [Parameter] 
        public RenderFragment<TItem> ChildContent { get; set; }
        
    }
}