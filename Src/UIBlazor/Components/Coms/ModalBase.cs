using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace UIBlazor.Components.Coms
{
    public class ModalBase : ComsBase
    {
        protected string[] ModalState = new string[]
        {
            "modal",
            "modal is-active"
        };

        /// <summary>
        /// 是否弹出模态框
        /// </summary>
        [Parameter]
        public bool IsActive { get; set; }

        /// <summary>
        /// 是否关闭右上角的关闭按钮，默认为显示
        /// </summary>
        [Parameter]
        public bool IsShowClose { get; set; } = true;

        /// <summary>
        /// 模态框自动适应内容的大小
        /// </summary>
        [Parameter]
        public bool IsAutoSize { get; set; }

        /// <summary>
        /// 关闭按钮大小
        /// </summary>
        [Parameter]
        public UIEButtonSize CloseSize { get; set; } = UIEButtonSize.Large;
        protected string closeSize;
        protected override void UIInit()
        {
            closeSize = CacheData.GetUIEButtonSize(CloseSize);
        }
        protected void ModalClose(MouseEventArgs e)
        {
            IsActive = false;
        }
    }
}
