using System;
using System.Windows;
using PaControl.Data;
using PaControl.Themes;
using PaControl.Tools;

namespace PaControlDemo.Resources;

public class DemoTheme : Theme
{
    public override ResourceDictionary GetSkin(SkinType skinType) =>
        ResourceHelper.GetSkin(typeof(App).Assembly, "Resources/Themes", skinType);

    public override ResourceDictionary GetTheme() => new()
    {
        Source = new Uri("pack://application:,,,/PaControlDemo;component/Resources/Themes/Theme.xaml")
    };
}
