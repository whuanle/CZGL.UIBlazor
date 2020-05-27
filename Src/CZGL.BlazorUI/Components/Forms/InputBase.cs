using CZGL.BlazorUI.Datas;
using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZGL.BlazorUI.Components.Forms
{
    public class InputBase : FormBase
    {
        /// <summary>
        /// Color
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        /// <summary>
        /// 设置 placeholder
        /// </summary>
        [Parameter]
        public string Placeholder { get; set; }

        /// <summary>
        /// Input 框类型
        /// </summary>
        [Parameter]
        public UIEInputType Type { get; set; }

        /// <summary>
        /// 是否圆角边框
        /// </summary>
        [Parameter]
        public bool IsRounded { get; set; }

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

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> MouseDownEventArg { get; set; }

        protected string InputType;
        protected override void UIInit()
        {
            InputType = CacheData.GetUIEInputType(Type);
            _allClass =
                CacheData.GetUIEColor(Color) +
                CacheData.GetUIETextSize(Size) +
                CacheData.GetUIEState(State) +
                (IsRounded ? " is-rounded" : "") +
                (IsStatic ? " is-static" : "")
                ;
        }
    }
}
