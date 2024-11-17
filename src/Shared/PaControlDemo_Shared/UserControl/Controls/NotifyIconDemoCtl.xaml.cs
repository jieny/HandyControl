using System.Windows;
using PaControlDemo.Tools;
using PaControlDemo.ViewModel;

namespace PaControlDemo.UserControl;

public partial class NotifyIconDemoCtl
{
    public NotifyIconDemoCtl()
    {
        InitializeComponent();

        AssemblyHelper.Register(nameof(NotifyIconDemoCtl), this);
        Unloaded += NotifyIconDemoCtl_Unloaded;
    }

    private void NotifyIconDemoCtl_Unloaded(object sender, RoutedEventArgs e) => ViewModelLocator.Instance.NotifyIconDemo.Cleanup();

    private void ButtonPush_OnClick(object sender, RoutedEventArgs e) => NotifyIconContextContent.CloseContextControl();
}
