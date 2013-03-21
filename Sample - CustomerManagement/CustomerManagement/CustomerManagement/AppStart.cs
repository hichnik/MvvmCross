using Cirrious.MvvmCross.ViewModels;
using CustomerManagement.Core.ViewModels;

namespace CustomerManagement.Core
{
    public class AppStart 
        : MvxNavigatingObject
        , IMvxAppStart
    {
        public void Start(object hint = null)
        {
            this.ShowViewModel<CustomerListViewModel>();
        }

        public bool ApplicationCanOpenBookmarks
        {
            get { return false; }
        }
    }
}