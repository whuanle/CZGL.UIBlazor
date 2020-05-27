using CZGL.BlazorUI.Datas;
using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;

namespace CZGL.BlazorUI.Components.Elements
{
    public class BarBase : ElementBase
    {
        /// <summary>
        /// 进度条当前值
        /// </summary>
        [Parameter]
        public double? Value { get; set; }

        /// <summary>
        /// 进度条颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 进度条粗细
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        protected override void UIInit()
        {
            _allClass = CacheData.GetUIEColor(Color) + " " + CacheData.GetUIETextSize(Size);
        }
    }
}
