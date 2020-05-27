using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class FieldBase : FormBase
    {

        /// <summary>
        /// 是否加入插件
        /// </summary>
        [Parameter]
        public bool IsAddon { get; set; }

        /// <summary>
        /// 表单组件对齐方向，Justify 对其无效
        /// </summary>
        [Parameter]
        public UIEAlign Align { get; set; } = UIEAlign.None;

        /// <summary>
        /// 是否设置为表单组
        /// </summary>
        [Parameter]
        public bool IsGrouped { get; set; }

        /// <summary>
        /// 组合表单控件对齐方式，Justify 对其无效
        /// </summary>
        [Parameter]
        public UIEAlign GroupedAlign { get; set; }

        /// <summary>
        /// 是否允许表单组多展示
        /// </summary>
        [Parameter]
        public bool IsGroupedMultiline { get; set; }

        /// <summary>
        /// 表单是否水平排版
        /// </summary>
        [Parameter]
        public bool IsHorizontal { get; set; }

        /// <summary>
        /// 是否禁用表单
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; } = false;

        private static readonly string[] align = new string[]
        {
            "",
            " has-addons-centered",
            " has-addons-centered",
            "",
            " has-addons-right"
        };
        private static readonly string[] groupAlign = new string[]
        {
            "",
            " is-grouped-centered",
            "is-grouped-centered",
            "",
            "is-grouped-right"
        };

        protected override void UIInit()
        {
            _allClass = (IsAddon ? " has-addons" : "") +
                (IsGrouped ? (" is-grouped" + groupAlign[(int)GroupedAlign] + (IsGroupedMultiline ? " is-grouped-multiline" : "")) : "") +
                align[(int)Align] +
                (IsHorizontal ? " is-horizontal" : "");
        }
    }
}
