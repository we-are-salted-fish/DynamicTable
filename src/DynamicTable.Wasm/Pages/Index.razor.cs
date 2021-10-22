using DynamicTable.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DynamicTable.Wasm.Pages
{
    public partial class Index
    {

        private int PageIndex { get; set; } = 0;

        private int PageSize { get; set; } = 10;
        
        
        [Inject]
        private HttpClient Http { get; set; }

        private User[] Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
        }

        protected virtual async Task LoadDataAsync()
        {
            Users = await Http.GetFromJsonAsync<User[]>($"api/user?page={PageIndex}&pagesize={PageSize}");    
        }

        private async Task SetPageIndex()
        {
            PageIndex = PageIndex + 1;
            await LoadDataAsync();
        }
    }
}
