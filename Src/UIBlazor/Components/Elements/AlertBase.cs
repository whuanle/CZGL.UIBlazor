using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
{
    public class AlertBase : ElementBase
    {
        /// <summary>
        /// 框颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 颜色淡一些
        /// </summary>
        [Parameter]
        public bool IsLight { get; set; }

        /// <summary>
        /// 内部的文本如何对齐
        /// </summary>
        [Parameter]
        public UIEAlign TextAlign { get; set; }

        protected override void UIInit()
        {
            _allClass =
                CacheData.GetUIEColor(Color) +
                CacheData.GetUIEAlign(TextAlign)+
                (IsLight ? " is-light" : "");
        }
    }
}
