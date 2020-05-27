using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
{
    /// <summary>
    /// Icon 图标
    /// </summary>
    public class IconBase : ElementBase
    {
        /// <summary>
        /// Icon图标类样式
        /// </summary>
        [Parameter]
        public string IconClass { get; set; }

        /// <summary>
        /// 设置图标大小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        /// <summary>
        /// 图标颜色
        /// </summary>
        [Parameter]
        public UIETextColor Color { get; set; }

        /// <summary>
        /// 图标是否靠右，默认靠左
        /// </summary>
        [Parameter]
        public bool IsRight { get; set; }
        protected string spanClass;
        protected override void UIInit()
        {
            _allClass =
                CacheData.GetTextColor(Color) + CacheData.GetUIETextSize(Size) + (IsRight ? " is-right" : " is-left");
        }
    }
}
