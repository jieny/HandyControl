using System.Windows;

namespace PaControlDemo.Window;

public partial class NoNonClientAreaDragableWindow
{
    public NoNonClientAreaDragableWindow()
    {
        InitializeComponent();
    }

    private void ButtonClose_OnClick(object sender, RoutedEventArgs e) => Close();
}
