using HomeyMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeyMvvm.Common
{
    class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel { get { return new MainWindowViewModel(); } }
        public HomeViewModel HomeViewModel { get { return new HomeViewModel(); } }
        public TodoDetailsViewModel TodoDetailsViewModel { get { return new TodoDetailsViewModel(); } }
    }
}
