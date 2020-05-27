using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class RadioBase : FormBase
    {
        [Parameter]
        public string Name { get; set; }

        protected override void UIInit()
        {
        }
    }
}
