using System.Windows;
using GalaSoft.MvvmLight.Command;
using PaControl.Controls;
using PaControl.Data;
using PaControlDemo.Data;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class TabControlDemoViewModel : DemoViewModelBase<TabControlDemoModel>
{
    public TabControlDemoViewModel(DataService dataService) => DataList = dataService.GetTabControlDemoDataList();

    public RelayCommand<CancelRoutedEventArgs> ClosingCmd => new(Closing);

    private void Closing(CancelRoutedEventArgs args)
    {
        Growl.Info($"{(args.OriginalSource as TabItem)?.Header} Closing");
    }

    public RelayCommand<RoutedEventArgs> ClosedCmd => new(Closed);

    private void Closed(RoutedEventArgs args)
    {
        Growl.Info($"{(args.OriginalSource as TabItem)?.Header} Closed");
    }
}
