using System.Windows;

namespace PaControl.Controls;

public class PlainTextPropertyEditor : PropertyEditorBase
{
    public override FrameworkElement CreateElement(PropertyItem propertyItem) => new System.Windows.Controls.TextBox
    {
        IsReadOnly = propertyItem.IsReadOnly
    };

    public override DependencyProperty GetDependencyProperty() => System.Windows.Controls.TextBox.TextProperty;
}
