using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CZGL.BlazorUI.UIEnum
{
    public enum UIEEquip
    {
        None = 0,

        /// <summary>
        /// 移动设备
        /// </summary>
        Mobile = 1,

        /// <summary>
        /// 平板设备
        /// </summary>
        Tablet = 2,

        /// <summary>
        /// 桌面设备
        /// </summary>
        Desptop = 3,

        /// <summary>
        /// 超宽屏
        /// </summary>
        Widescreen = 4,

        /// <summary>
        ///极宽
        /// </summary>
        Fullhd = 5
    }
    public class ColumnEquip
    {
        public UIEColumnSize Size { get; set; }
        public UIEEquip Equip { get; set; }
    }
}
