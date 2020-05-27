using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZGL.BlazorUI.Components.Coms
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
