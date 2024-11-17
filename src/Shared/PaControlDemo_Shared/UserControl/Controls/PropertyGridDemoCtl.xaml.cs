using System.Windows;
using PaControlDemo.Data;

namespace PaControlDemo.UserControl;

public partial class PropertyGridDemoCtl
{
    public PropertyGridDemoCtl()
    {
        InitializeComponent();

        DemoModel = new PropertyGridDemoModel
        {
            String = "TestString",
            Enum = Gender.Female,
            Boolean = true,
            Integer = 98,
            VerticalAlignment = VerticalAlignment.Stretch
        };
    }

    public static readonly DependencyProperty DemoModelProperty = DependencyProperty.Register(
        nameof(DemoModel), typeof(PropertyGridDemoModel), typeof(PropertyGridDemoCtl), new PropertyMetadata(default(PropertyGridDemoModel)));

    public PropertyGridDemoModel DemoModel
    {
        get => (PropertyGridDemoModel) GetValue(DemoModelProperty);
        set => SetValue(DemoModelProperty, value);
    }
}
