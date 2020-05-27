using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class ControlBase : FormBase
    {
        /// <summary>
        /// 是否显示Icon图标,Justify 和 Center 是等效的。
        /// </summary>
        [Parameter]
        public UIEAlign IconAlign { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Parameter]
        public bool IsLoading { get; set; }
        private static readonly string[] align = new string[]
        {
            "",
            " has-icons-left has-icons-right",
            " has-icons-left has-icons-right",
            " has-icons-left",
            " has-icons-right"
        };

        /// <summary>
        /// 是否拓展填充剩余空间
        /// </summary>
        [Parameter]
        public bool IsExpanded { get; set; }
        protected override void UIInit()
        {
            _allClass =
                align[(int)IconAlign] +
                (IsLoading ? " is-loading" : "") +
                (IsExpanded ? " is-expanded" : "")
                ;
        }
    }
}
