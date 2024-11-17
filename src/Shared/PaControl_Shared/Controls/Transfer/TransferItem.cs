using System.Windows;
using System.Windows.Controls;
using PaControl.Data;

namespace PaControl.Controls;

public class TransferItem : ListBoxItem
{
    public static readonly DependencyProperty IsTransferredProperty = DependencyProperty.Register(
        nameof(IsTransferred), typeof(bool), typeof(TransferItem), new PropertyMetadata(ValueBoxes.FalseBox));

    public bool IsTransferred
    {
        get => (bool) GetValue(IsTransferredProperty);
        set => SetValue(IsTransferredProperty, ValueBoxes.BooleanBox(value));
    }
}
