using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class CheckboxBase : FormBase
    {
        [Parameter]
        public string Name { get; set; }

        protected override void UIInit()
        {
        }
    }
}
