using Microsoft.AspNetCore.Components;


namespace UIBlazor.Components.Coms
{
    public class DropdownBase : ComsBase
    {
        /// <summary>
        /// 是否要鼠标点击才能显示下来选择。默认鼠标移动到元素即可显示下拉框。
        /// </summary>
        [Parameter]
        public bool IsMouseDown { get; set; } = false;
        /// <summary>
        /// 标题
        /// </summary>
        [Parameter]
        public RenderFragment Title { get; set; }

        /// <summary>
        /// 底部标题
        /// </summary>
        [Parameter]
        public RenderFragment Footer { get; set; }

        protected override void UIInit()
        {
            throw new System.NotImplementedException();
        }
    }
}
