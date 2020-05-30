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
        /// 是否靠右浮动
        /// </summary>
        [Parameter]
        public bool IsRight { get; set; }

        /// <summary>
        /// 向上显示
        /// </summary>
        [Parameter]
        public bool IsUp { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [Parameter]
        public RenderFragment DropTitle { get; set; }

        /// <summary>
        /// 底部标题
        /// </summary>
        [Parameter]
        public RenderFragment DropFoot { get; set; }

        protected override void UIInit()
        {
        }
    }
}
