using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MonoNetConnect.Controller
{
    public interface IBaseViewController
    {
        void ItemClicked();
    }
    public abstract class BaseViewController<T> : IBaseViewController
        where T : IBaseViewController
    {
        protected T _viewController { get; set; }

        protected BaseViewController(T viewController)
        {
            this._viewController = viewController;
        }

        public void ItemClicked()
        {
            this._viewController.ItemClicked();
        }
    }
}