using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Layouts
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
