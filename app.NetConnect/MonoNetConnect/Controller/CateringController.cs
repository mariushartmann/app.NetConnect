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
    public interface ICateringController : IBaseViewController
    {

    }
    class CateringController : BaseViewController<ICateringController>, ICateringController
    {
        public CateringController(ICateringController viewController)
            :base(viewController)
        {

        }
    }
}