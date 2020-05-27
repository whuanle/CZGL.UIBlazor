namespace CZGL.BlazorUI.Datas
{
    /// <summary>
    /// 辅助类型，处理一些样式
    /// </summary>
    public enum UIEAssistOther
    {
        /// <summary>
        /// 什么也不做
        /// </summary>
        None = 0,

        /// <summary>
        /// 完全覆盖上一层定位得元素
        /// </summary>
        Overlay = 1,
        
        /// <summary>
        /// 隐藏溢出部分
        /// </summary>
        Clipped = 2,

        /// <summary>
        /// 移除任何 radius(圆角) 效果
        /// </summary>
        RadiusLess = 3,

        /// <summary>
        /// 移除任何 shadow(阴影) 效果
        /// </summary>
        ShadowLess = 4,

        /// <summary>
        /// 禁止文本选择
        /// </summary>
        UnSelectable = 5,

        /// <summary>
        /// 增加了可视性隐藏
        /// </summary>
        Invisible = 6,

        /// <summary>
        /// 隐藏元素
        /// </summary>
        Hidden = 7,

        /// <summary>
        /// 隐藏元素，但是依然可以被屏幕阅读器识别
        /// </summary>
        SrOnly = 8,

        /// <summary>
        /// 给元素设置 position: relative 属性
        /// </summary>
        Relative = 9
    }
}
