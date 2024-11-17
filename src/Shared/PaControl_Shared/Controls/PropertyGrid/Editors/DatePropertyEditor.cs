using System.Windows;

namespace PaControl.Controls;

public class DatePropertyEditor : PropertyEditorBase
{
    public override FrameworkElement CreateElement(PropertyItem propertyItem) => new DateTimePicker
    {
        IsEnabled = !propertyItem.IsReadOnly
    };

    public override DependencyProperty GetDependencyProperty() => System.Windows.Controls.DatePicker.SelectedDateProperty;
}
