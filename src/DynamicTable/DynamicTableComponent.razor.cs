using System;
using System.Threading.Tasks;
using DynamicTable.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace DynamicTable
{
    public partial class DynamicTableComponent
    {
        
        [Parameter]
        public TableConfig TableConfig { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        protected override Task OnInitializedAsync()
        {
            if (TableConfig == null)
            {
                throw new Exception($"错误 {nameof(TableConfig)}");
            }
            return base.OnInitializedAsync();
        }
    }
}