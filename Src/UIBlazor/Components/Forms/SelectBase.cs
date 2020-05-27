using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class SelectBase : FormBase
    {
        /// <summary>
        /// 设置显示行数
        /// </summary>
        [Parameter]
        public int? Line { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 是否圆角边框
        /// </summary>
        [Parameter]
        public bool IsRounded { get; set; }

        /// <summary>
        /// 是否全宽度
        /// </summary>
        [Parameter]
        public bool IsFullWidth { get; set; }

        /// <summary>
        /// 控件状态
        /// </summary>
        [Parameter]
        public UIEState State { get; set; }
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
               CacheData.GetUIEState(State) +
                (IsRounded ? " is-rounded" : "") +
                (IsFullWidth ? " is-fullwidth" : "");
        }
    }
}
