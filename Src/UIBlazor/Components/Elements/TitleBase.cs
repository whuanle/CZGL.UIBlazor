using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
{
    public class TitleBase : ElementBase
    {
        [Parameter]
        public bool IsSubTitle { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }
        protected override void UIInit()
        {
            _allClass = CacheData.GetUIEColor(Color);
        }
    }
}
