using UIBlazor.Datas;
using UIBlazor.UIEnum;
using Microsoft.AspNetCore.Components;

namespace UIBlazor.Components.Forms
{
    public class FileBase : FormBase
    {
        [Parameter]
        public string Name { get; set; }

        /// <summary>
        /// 未选择文件时，显示的文字
        /// </summary>
        [Parameter]
        public string FileDefaultName { get; set; }

        /// <summary>
        /// 是否显示选择的文件名
        /// </summary>
        [Parameter]
        public bool IsShowFile { get; set; }

        /// <summary>
        /// 是否完整显示文件完整路径地址，默认显示
        /// </summary>
        [Parameter]
        public bool IsHasPath { get; set; } = true;

        /// <summary>
        /// 是否显示为盒子
        /// </summary>
        [Parameter]
        public bool IsBox { get; set; }
        protected string FileName { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [Parameter]
        public UIETextSize Size { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        [Parameter]
        public UIEColor Color { get; set; }
        protected override void UIInit()
        {
            _allClass = (IsBox ? "is-boxed" : "") +
                CacheData.GetUIEColor(Color) +
                CacheData.GetUIETextSize(Size);
            FileName = FileDefaultName;
        }
        protected void SelectFile(ChangeEventArgs e)
        {
            FileName = IsHasPath ? e.Value.ToString() : System.IO.Path.GetFileName(e.Value.ToString());
            StateHasChanged();
        }
    }
}
