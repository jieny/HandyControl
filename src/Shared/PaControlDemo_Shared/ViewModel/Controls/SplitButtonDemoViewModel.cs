using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PaControl.Controls;

namespace PaControlDemo.ViewModel;

public class SplitButtonDemoViewModel : ViewModelBase
{
    public RelayCommand<string> SelectCmd => new(str => Growl.Info(str));
}
