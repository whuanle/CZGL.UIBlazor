using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;
using CZGL.BlazorUI.Datas;
using Microsoft.AspNetCore.Components.Web;

namespace CZGL.BlazorUI.Components.Elements
{
    public class ButtonBase : ElementBase
    {

        /// <summary>
        /// 按钮颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }

        /// <summary>
        /// 是否全宽
        /// </summary>
        [Parameter]
        public bool IsFullWidth { get; set; }

        /// <summary>
        /// 是否带边框
        /// </summary>
        [Parameter]
        public bool IsOutLine { get; set; }


        /// <summary>
        /// 是否反转背景颜色
        /// </summary>
        [Parameter]
        public bool IsInverted { get; set; }

        /// <summary>
        /// 是否圆角
        /// </summary>
        [Parameter]
        public bool IsRounded { get; set; }

        /// <summary>
        /// 是否浅色
        /// </summary>
        [Parameter]
        public bool IsLoading { get; set; }

        /// <summary>
        /// 颜色变淡
        /// </summary>
        [Parameter]
        public bool IsLight { get; set; }

        /// <summary>
        /// 设置按钮为静态，即不显示任何效果
        /// </summary>
        [Parameter]
        public bool IsStatic { get; set; }
        
        /// <summary>
        /// 按钮大小
        /// </summary>
        [Parameter]
        public UIEButtonSize Size { get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        [Parameter]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> DownEvent { get; set; }
        protected override void UIInit()
        {
            _allClass =
                CacheData.GetUIEColor(Color) + " " +
                CacheData.GetUIEButtonSize(Size) +
                (IsFullWidth ? " is-fullwidth " : " ") +
                (IsLight ? " is-light" : "") +
                (IsOutLine ? " is-outlined " : " ") +
                (IsInverted ? " is-inverted " : " ") +
                (IsRounded ? " is-rounded " : " ") +
                (IsLoading ? " is-loading " : " ") +
                (IsStatic ? " is-static " : " ")
                ;
        }
    }
}
