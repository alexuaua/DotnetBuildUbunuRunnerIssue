using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Client.Pages;
public partial class Counter : ComponentBase
{
    [Inject, AllowNull]
    private IJSRuntime JSRuntime { get; set; }
    private IJSObjectReference JSModule { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            Debug.WriteLine("Hit OnAfterRenderAsync in Index.razor.cs!");
            Console.WriteLine("Hit OnAfterRenderAsync in Index.razor.cs in Console!");
            JSModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./Pages/Counter.razor.js");
        }
    }

    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
