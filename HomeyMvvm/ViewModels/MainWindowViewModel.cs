using HomeyMvvm.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HomeyMvvm.ViewModels
{

    public class MainWindowViewModel : BaseViewModel
    {
        private readonly ICommand _ExitCmd;
        private readonly ICommand _MinimizeToTrayCmd;


        public ICommand ExitCmd { get { return (_ExitCmd); } }
        public ICommand MinimizeToTrayCmd { get { return (_MinimizeToTrayCmd); } }



        public MainWindowViewModel()
        {
            //Initialize the command
            _ExitCmd = new RelayCommand(ExecExit, CanExit);
            _MinimizeToTrayCmd = new RelayCommand(ExecMinimizeToTrayCmd, CanMinimizeToTray);
        }


        private void ExecExit(object obj)
        {
            //Todo: Add the functionality for ExitCmd Here
            System.Windows.Application.Current.Shutdown();
        }

        [DebuggerStepThrough]
        private bool CanExit(object obj)
        {
            //Todo: Add the checking for CanExit Here
            return (true);
        }

        //These methods are checked again & again in loop, so we will step through them while debugging
        [DebuggerStepThrough]
        private bool CanMinimizeToTray(object obj)
        {
            return (true);
        }

        private void ExecMinimizeToTrayCmd(object obj)
        {
            var win = (Window)obj;

            var notifyIcon = NotifyIconHelper.Instance.GetIcon(win);

            notifyIcon.Visible = true;
            win.Hide();
        }
    }
}
