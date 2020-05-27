using CZGL.BlazorUI.Datas;
using CZGL.BlazorUI.UIEnum;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZGL.BlazorUI.Components.Layouts
{
    public class TileBase : LayoutBase
    {
        /// <summary>
        /// 层次修饰符，用于设置外内层关系
        /// </summary>
        [Parameter]
        public UIERelation Relation { get; set; }

        /// <summary>
        /// 是否垂直对齐
        /// </summary>
        [Parameter]
        public bool IsVertical { get; set; }

        /// <summary>
        /// 尺寸大小
        /// </summary>
        [Parameter]
        public UIEXSize Size { get; set; }
        protected override void UIInit()
        {
            _allClass =
                CacheData.GetUIERelation(Relation) +
                (IsVertical ? " is-vertical" : "") +
                CacheData.GetUIEXSize(Size);
            ;
        }
    }
}
