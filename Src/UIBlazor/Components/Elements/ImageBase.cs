using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
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