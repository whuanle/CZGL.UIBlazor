using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Layouts
{
    public class HeroBase : LayoutBase
    {
        /// <summary>
        /// 是否生成渐变
        /// </summary>
        [Parameter]
        public bool IsBold { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 是否全高
        /// </summary>
        [Parameter]
        public bool IsFullHeight { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        protected override void UIInit()
        {
            _allClass =
                CacheData.GetUIEColor(Color) +
                CacheData.GetUIETextSize(Size) +
                (IsBold ? " is-bold" : "") +
                (IsFullHeight ? " is-fullheight-with-navbar" : "");
        }
    }
}
