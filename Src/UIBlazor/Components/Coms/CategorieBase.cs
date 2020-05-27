using Microsoft.AspNetCore.Components;
using System;

namespace UIBlazor.Components.Coms
{
    public class CategorieBase : ComsBase
    {
        /// <summary>
        /// 头部
        /// </summary>
        [Parameter]
        public RenderFragment Head { get; set; }

        protected override void UIInit()
        {
            throw new NotImplementedException();
        }
    }
}
