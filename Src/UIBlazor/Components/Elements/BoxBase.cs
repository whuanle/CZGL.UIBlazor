using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
{
    public class BoxBase : ElementBase
    {
        /// <summary>
        /// 文字颜色
        /// </summary>
        [Parameter]
        public UIETextColor TextColor { get; set; } = UIETextColor.None;

        /// <summary>
        /// 背景颜色
        /// </summary>
        [Parameter]
        public UIEBackColor BackgroundColor { get; set; } = UIEBackColor.None;

        /// <summary>
        /// 圆角边框
        /// </summary>
        [Parameter]
        public UIERadius Radius { get; set; } = UIERadius.None;

        /// <summary>
        /// 黑白之间的阴影
        /// </summary>
        [Parameter]
        public UIEShade Shadow { get; set; } = UIEShade.None;

        protected override void UIInit()
        {
            _allClass =
                CacheData.GetTextColor(TextColor)
                + CacheData.GetUIEBackColor(BackgroundColor)
                + CacheData.GetUIERadius(Radius)
                + CacheData.GetUIEShade(Shadow);
        }
    }
}