using System.Windows;

namespace PaControl.Controls;

public interface ISelectable
{
    event RoutedEventHandler Selected;

    bool IsSelected { get; set; }
}
