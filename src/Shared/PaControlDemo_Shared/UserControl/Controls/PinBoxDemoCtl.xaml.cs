using System.Windows;
using PaControl.Controls;

namespace PaControlDemo.UserControl;

public partial class PinBoxDemoCtl
{
    public PinBoxDemoCtl()
    {
        InitializeComponent();
    }

    private void PinBox_OnCompleted(object sender, RoutedEventArgs e)
    {
        if (e.OriginalSource is PinBox pinBox)
        {
            Growl.Info(pinBox.Password);
        }
    }
}
