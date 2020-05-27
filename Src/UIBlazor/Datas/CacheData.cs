using UIBlazor.UIEnum;

namespace UIBlazor.Datas
{
    public static class CacheData
    {
        #region 列

        // 列宽度大小
        private readonly static string[] UIEColumnSizeValue = new string[]
        {
            "",
            " is-three-quarters",
            " is-two-thirds",
            " is-half",
            " is-one-third",
            " is-one-quarter",
            " is-full",
            " is-four-fifths",
            " is-three-fifths",
            " is-two-fifths",
            " is-one-fifth",
            " is-1",
            " is-2",
            " is-3",
            " is-4",
            " is-5",
            " is-6",
            " is-7",
            " is-8",
            " is-9",
            " is-10",
            " is-11",
            " is-12",
            " is-narrow"
        };


        // 列偏移量
        private readonly static string[] UIEColumnOffsetValue = new string[]
        {
            "",
            " is-offset-three-quarters",
            " is-offset-two-thirds",
            " is-offset-half",
            " is-offset-one-third",
            " is-offset-one-quarter",
            " is-offset-full",
            " is-offset-four-fifths",
            " is-offset-three-fifths",
            " is-offset-two-fifths",
            " is-offset-one-fifth",
            " is-offset-1",
            " is-offset-2",
            " is-offset-3",
            " is-offset-4",
            " is-offset-5",
            " is-offset-6",
            " is-offset-7",
            " is-offset-8",
            " is-offset-9",
            " is-offset-10",
            " is-offset-11",
            " is-offset-12",
        };

        /// <summary>
        /// 列间隔
        /// </summary>
        private readonly static string[] UIEGapValue = new string[]
        {
            "",
            " is-variable is-1",
            " is-variable is-2",
            " is-variable is-3",
            " is-variable is-4",
            " is-variable is-5",
            " is-variable is-6",
            " is-variable is-7",
            " is-variable is-8",
            " is-variable is-0",
        };

        /// <summary>
        /// 列间隙
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEGap(UIEGap value)
        {
            return UIEGapValue[(int)value];
        }
        /// <summary>
        /// 获取列宽度
        /// </summary>
        /// <param name="value">列宽度</param>
        /// <returns></returns>
        public static string GetCoumnSizes(UIEColumnSize value)
        {
            return UIEColumnSizeValue[(int)value];
        }

        /// <summary>
        /// 获取列偏移量
        /// </summary>
        /// <param name="value">偏移量</param>
        /// <returns></returns>
        public static string GetCoumnOffsetSizes(UIEColumnOffset value)
        {
            return UIEColumnOffsetValue[(int)value];
        }

        /// <summary>
        /// 获取列间隙
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetColumGap(UIEGap value)
        {
            return UIEGapValue[(int)value];
        }

        #endregion

        // 基本颜色
        private readonly static string[] UIEColorValue = new string[]
        {
            "",
            " is-white",
            " is-black",
            " is-light",
            " is-dark",
            " is-primary",
            " is-link",
            " is-info",
            " is-success",
            " is-warning",
            " is-danger",
        };

        /// <summary>
        /// 基本颜色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEColor(UIEColor value)
        {
            return UIEColorValue[(int)value];
        }

        // 黑白阴影
        private readonly static string[] UIEShadeValue = new string[]
        {
            "",
            " white-bis",
            " while-ter",
            " grey-lighter",
            " grey-light",
            " grey-dark",
            " grey-darker",
            " black-ter",
            " black-bis"
        };

        /// <summary>
        /// 获取黑白阴影
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEShade(UIEShade value)
        {
            return UIEShadeValue[(int)value];
        }

        // 辅助类型，浮动元素
        private readonly static string[] UIAssistFlotValue = new string[]
        {
            "",
            " is-clearfix",
            " is-pulled-left",
            " is-pulled-right"
        };

        // 辅助类型，移除空间间隔
        private readonly static string[] UIAssistSpacingValue = new string[]
        {
            "",
            " is-marginless",
            " is-paddingless"
        };

        // 辅助类型
        private readonly static string[] UIAssistOtherValue = new string[]
        {
            "",
            " is-overlay",
            " is-clipped",
            " is-radiusless",
            " is-shadowless",
            " is-unselectable",
            " is-invisible",
            " is-hidden",
            " is-sr-only"
        };

        // 文本颜色
        private readonly static string[] UIETextColorValue = new string[]
        {
            "",
            " has-text-white",
            " has-text-black",
            " has-text-light",
            " has-text-dark",
            " has-text-primary",
            " has-text-info",
            " has-text-link",
            " has-text-success",
            " has-text-warning",
            " has-text-danger",
            " has-text-black-bis",
            " has-text-black-ter",
            " has-text-grey-darker",
            " has-text-grey-dark",
            " has-text-grey",
            " has-text-grey-light",
            " has-text-grey-lighter",
            " has-text-white-ter",
            " has-text-white-bis"
        };

        /// <summary>
        /// 获取文本颜色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetTextColor(UIETextColor value)
        {
            return UIETextColorValue[(int)value];
        }

        // 文本变大变小
        private static readonly string[] UIETextSizeValue = new string[]
        {
            "",
            " is-small",
            " is-medium",
            " is-large"
        };

        /// <summary>
        /// 获取文本变大变小
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIETextSize(UIETextSize value)
        {
            return UIETextSizeValue[(int)value];
        }

        /// <summary>
        /// 背景颜色
        /// </summary>
        /// <
        private readonly static string[] UIEBackColorValue = new string[]
        {
            "",
            " has-text-white",
            " has-text-black",
            " has-text-light",
            " has-text-dark",
            " has-text-primary",
            " has-text-info",
            " has-text-link",
            " has-text-success",
            " has-text-warning",
            " has-text-danger",
            " has-text-black-bis",
            " has-text-black-ter",
            " has-text-grey-darker",
            " has-text-grey-dark",
            " has-text-grey",
            " has-text-grey-light",
            " has-text-grey-lighter",
            " has-text-white-ter",
            " has-text-white-bis"
        };

        /// <summary>
        /// 获取背景颜色
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEBackColor(UIEBackColor value)
        {
            return UIEBackColorValue[(int)value];
        }

        // 排版辅助类型，元素大小
        private readonly static string[] UIEAssistSizeValue = new string[]
        {
            "",
            " is-size-1",
            " is-size-2",
            " is-size-3",
            " is-size-4",
            " is-size-5",
            " is-size-6",
            " is-size-7"
        };

        /// <summary>
        /// 元素对齐
        /// </summary>
        private readonly static string[] UIEAlignValue = new string[]
        {
            "",
            " has-text-centered",
            " has-text-justified",
            " has-text-left",
            " has-text-right"
        };

        /// <summary>
        /// 元素对齐
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEAlign(UIEAlign value)
        {
            return UIEAlignValue[(int)value];
        }

        private readonly static string[] UIETextTran = new string[]
        {
            "",
            " is-capitalized",
            " is-lowercase",
            " is-uppercase",
            " is-italic"
        };

        // 设置文字宽度
        private readonly static string[] UIETextWeight = new string[]
        {
            "",
            " has-text-weight-light",
            " has-text-weight-normal",
            " has-text-weight-medium",
            " has-text-weight-semibold",
            " has-text-weight-bold"
        };

        // 设置字体
        private readonly static string[] UIETextFamilyValue = new string[]
        {
            "",
            " is-family-sans-serif",
            " is-family-monospace",
            " is-family-primary",
            " is-family-secondary",
            " is-family-code"
        };

        // 圆角边框
        private readonly static string[] UIERadiusValue = new string[]
        {
            "",
            " radius-small",
            " radius",
            " radius-large",
            " radius-rounded"
        };

        /// <summary>
        /// 获取圆角边框
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIERadius(UIERadius value)
        {
            return UIERadiusValue[(int)value];
        }

        private readonly static string[] UIEButtonSizeValue = new string[]
        {
            "",
            " is-small",
            " is-normal",
            " is-medium",
            " is-large"
        };

        /// <summary>
        /// 获取按钮大小
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEButtonSize(UIEButtonSize value)
        {
            return UIEButtonSizeValue[(int)value];
        }

        private readonly static string[] UIEImageSizeValue = new string[]
        {
            "",
            " is-16x16",
            " is-24x24",
            " is-32x32",
            " is-48x48",
            " is-64x64",
            " is-96x96",
            " is-128x128",
            " is-1by1",
            " is-5by4",
            " is-4by3",
            " is-3by2",
            " is-5by3",
            " is-16by9",
            " is-2y1",
            " is-3by1",
            " is-4by5",
            " is-3by4",
            " is-2by3",
            " is-3by5",
            " is-9by6",
            " is-2by1",
            " is-1by3"

        };

        /// <summary>
        /// 获取图片样式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEImageSizeValue(UIEImageSize value)
        {
            return UIEImageSizeValue[(int)value];
        }

        // 祖 父 子
        private static readonly string[] UIERelationValue = new string[]
        {
            "",
            " is-ancestor",
            " is-parent",
            " is-child"
        };

        /// <summary>
        /// 祖 父 子
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIERelation(UIERelation value)
        {
            return UIERelationValue[(int)value];
        }

        // 十二水平尺寸
        private static readonly string[] UIEXSizeValue = new string[]
        {
            "",
            " is-1",
            " is-2",
            " is-3",
            " is-4",
            " is-5",
            " is-6",
            " is-7",
            " is-8",
            " is-9",
            " is-10",
            " is-11",
            " is-12"
        };

        /// <summary>
        /// 十二水平尺寸
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEXSize(UIEXSize value)
        {
            return UIEXSizeValue[(int)value];
        }

        // input type
        private static readonly string[] UIEInputTypeValue = new string[]
        {
            "text",
            "button",
            "checkbox",
            "color",
            "date",
            "datetime",
            "datetime-local",
            "month",
            "week",
            "time",
            "email",
            "file",
            "hidden",
            "image",
            "number",
            "password",
            "radio",
            "range",
            "reset",
            "search",
            "submit",
            "tel",
            "text",
            "url"
        };
        /// <summary>
        /// input type
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEInputType(UIEInputType value)
        {
            return UIEInputTypeValue[(int)(value)];
        }

        // 控件状态
        private static readonly string[] UIEStateValue = new string[]
        {
            "",
            " is-hoverd",
            " is-focused",
            " is-loading"
        };

        /// <summary>
        /// 控件状态
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetUIEState(UIEState value)
        {
            return UIEStateValue[(int)value];
        }

        private readonly static string[] styleTypeValue = new string[]
        {
            "",
            "is-outlined",
            "is-loading",
            "[disabled]"
        };

    }
}