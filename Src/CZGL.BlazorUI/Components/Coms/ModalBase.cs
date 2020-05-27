using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CZGL.BlazorUI.UIEnum;
using CZGL.BlazorUI.Datas;

namespace CZGL.BlazorUI.Components.Coms
{
    public class ModalBase : ComsBase
    {
        private bool active = false;
        private static readonly string[] ModalState = new string[]
        {
            "modal",
            "modal is-active"
        };

        /// <summary>
        /// 是否弹出模态框
        /// </summary>
        [Parameter]
        public bool IsActive { get { return active; } set { active = value; _allClass = (IsActive ? ModalState[1] : ModalState[0]); } }

        /// <summary>
        /// 关闭按钮大小
        /// </summary>
        [Parameter]
        public UIEButtonSize CloseSize { get; set; } = UIEButtonSize.Large;
        protected string closeSize;
        protected override void UIInit()
        {
            _allClass = (IsActive ? ModalState[1] : ModalState[0]);
            closeSize = CacheData.GetUIEButtonSize(CloseSize);
        }
        protected void ModalClose(MouseEventArgs e)
        {
            IsActive = false;
        }
    }
}
