using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZGL.BlazorUI.Components.Forms
{
    public class RadioBase:FormBase
    {
        [Parameter]
        public string Name { get; set; }

        protected override void UIInit()
        {
        }
    }
}
