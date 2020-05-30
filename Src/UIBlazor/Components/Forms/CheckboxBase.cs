using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class CheckboxBase : FormBase
    {
        [Parameter]
        public string Name { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [Parameter]
        public bool IsDisable { get; set; }
        protected override void UIInit()
        {
        }
    }
}
