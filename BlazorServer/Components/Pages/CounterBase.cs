using Microsoft.AspNetCore.Components;

namespace BlazorServer.Components.Pages
{
    public class CounterBase:ComponentBase
    {

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
