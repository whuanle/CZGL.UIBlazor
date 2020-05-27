using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class TextareaBase : FormBase
    {
        /// <summary>
        /// 设置 placeholder
        /// </summary>
        [Parameter]
        public string Placeholder { get; set; }

        /// <summary>
        /// 文本域能够显示多少行
        /// </summary>
        [Parameter]
        public int? Rows { get; set; }

        /// <summary>
        /// 文本域每行显示字数
        /// </summary>
        [Parameter]
        public int? Cols { get; set; }

        /// <summary>
        /// 文本框样式
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 文本域大小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        /// <summary>
        /// 控件状态
        /// </summary>
        [Parameter]
        public UIEState State { get; set; }
        /// <summary>
        /// 禁用组件
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// 只读
        /// </summary>
        [Parameter]
        public bool IsReadonly { get; set; }

        /// <summary>
        /// 是否静态
        /// </summary>
        [Parameter]
        public bool IsStatic { get; set; }
        protected override void UIInit()
        {

            _allClass =
                CacheData.GetUIEColor(Color) +
                 CacheData.GetUIEState(State) +
                (CacheData.GetUIETextSize(Size)) +
                (IsStatic ? " is-static" : "");
        }
    }
}
