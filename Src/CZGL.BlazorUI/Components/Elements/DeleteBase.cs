using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CZGL.BlazorUI.Datas;
using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace CZGL.BlazorUI.Components.Elements
{
    public class DeleteBase : ElementBase
    {
        [Parameter]
        public UIETextSize Size { get; set; } = UIETextSize.None;

        /// <summary>
        /// 鼠标点击事件
        /// </summary>
        [Parameter]
        public EventCallback<MouseEventArgs> MouseEventArg { get; set; }
        protected override void UIInit()
        {
            _allClass = CacheData.GetUIETextSize(Size);
        }
    }
}
