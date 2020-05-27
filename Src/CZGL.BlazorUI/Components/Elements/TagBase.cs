using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CZGL.BlazorUI.Datas;
using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;

namespace CZGL.BlazorUI.Components.Elements
{
    public class TagBase : ElementBase
    {
        /// <summary>
        /// 颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }


        /// <summary>
        /// 变大或变小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }

        protected override void UIInit()
        {
            _allClass = CacheData.GetUIEColor(Color) + " " + CacheData.GetUIETextSize(Size);
        }
    }
}
