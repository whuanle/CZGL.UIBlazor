using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace UIBlazor.Components.Coms
{
    public abstract class ComsBase : ComponentBase
    {
        protected string _allClass;

        /// <summary>
        /// 自定义组件元素属性
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UIAttributes { get; set; }

        /// <summary>
        /// 内嵌子元素
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        #region 初始化和动态刷新组件

        protected override void OnInitialized()
        {
            if (RefreshEvent.HasDelegate)
            {
                RefreshEvent.InvokeAsync(new EventCallbackFactory().Create(new object(), Refresh)).Wait();
            }

            UIInit();
        }

        /// <summary>
        /// 刷新控件
        /// </summary>
        [Parameter]
        public EventCallback<EventCallback> RefreshEvent { get; set; }

        /// <summary>
        /// 不要在 OnInitialized 初始化组件，而是在 UIInit() 初始化组件
        /// </summary>
        protected abstract void UIInit();

        protected virtual void Refresh(object obj)
        {
            UIInit();
            StateHasChanged();
        }
        
        #endregion
    }
}
