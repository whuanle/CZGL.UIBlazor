using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CZGL.BlazorUI.UIEnum;
using CZGL.BlazorUI.Datas;

namespace CZGL.BlazorUI.Components.Elements
{
    public class ImageBase : ElementBase
    {
        /// <summary>
        /// 图片大小
        /// </summary>
        [Parameter]
        public UIEImageSize Size { get; set; }

        /// <summary>
        /// 是否圆角图片
        /// </summary>
        [Parameter]
        public bool IsRounded { get; set; }
        protected override void UIInit()
        {
            _allClass =
                CacheData.GetUIEImageSizeValue(Size) +
                (IsRounded ? " is-rounded" : "");
        }
    }
}