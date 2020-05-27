using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Elements
{
    /// <summary>
    /// 用于处理文本内容
    /// </summary>
    public class ContentBase : ElementBase
    {
        /// <summary>
        /// 设置文本变大还是变小
        /// </summary>
        [Parameter]
        public UIETextSize TextSize { get; set; } = UIETextSize.None;

        /// <summary>
        /// 文字对齐
        /// </summary>
        [Parameter]
        public UIEAlign Align { get; set; } = UIEAlign.None;

        protected override void UIInit()
        {
            _allClass = CacheData.GetUIETextSize(TextSize) + CacheData.GetUIEAlign(Align);
        }
    }
}
