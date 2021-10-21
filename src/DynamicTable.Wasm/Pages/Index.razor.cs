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
        [Inject]
        private HttpClient Http { get; set; }

        private User[] Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Users = await Http.GetFromJsonAsync<User[]>("api/user?page=0&pagesize=10");
        }
    }
}
