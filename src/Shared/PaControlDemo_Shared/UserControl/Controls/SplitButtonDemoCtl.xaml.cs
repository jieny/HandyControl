using System.Windows;

namespace PaControlDemo.UserControl;

public partial class SplitButtonDemoCtl
{
    public SplitButtonDemoCtl()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("123");
    }
}
