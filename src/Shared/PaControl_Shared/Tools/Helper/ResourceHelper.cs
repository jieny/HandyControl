using System;
using System.Reflection;
using System.Windows;
using PaControl.Data;

namespace PaControl.Tools;

/// <summary>
///     资源帮助类
/// </summary>
public class ResourceHelper
{
    private static ResourceDictionary _theme;

    /// <summary>
    ///     获取资源
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static T GetResource<T>(string key)
    {
        if (Application.Current.TryFindResource(key) is T resource)
        {
            return resource;
        }

        return default;
    }

    internal static T GetResourceInternal<T>(string key)
    {
        if (GetTheme()[key] is T resource)
        {
            return resource;
        }

        return default;
    }

    /// <summary>
    ///     获取皮肤
    /// </summary>
    public static ResourceDictionary GetSkin(Assembly assembly, string themePath, SkinType skin)
    {
        try
        {
            var uri = new Uri($"pack://application:,,,/{assembly.GetName().Name};component/{themePath}/Skin{skin}.xaml");
            return new ResourceDictionary
            {
                Source = uri
            };
        }
        catch
        {
            return new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/{assembly.GetName().Name};component/{themePath}/Skin{SkinType.Default}.xaml")
            };
        }
    }

    /// <summary>
    ///     get PaControl skin
    /// </summary>
    /// <param name="skin"></param>
    /// <returns></returns>
    public static ResourceDictionary GetSkin(SkinType skin) => new()
    {
        Source = new Uri($"pack://application:,,,/PaControl;component/Themes/Skin{skin}.xaml")
    };

    /// <summary>
    ///     get PaControl theme
    /// </summary>
    public static ResourceDictionary GetTheme() => _theme ??= GetStandaloneTheme();

    public static ResourceDictionary GetStandaloneTheme()
    {
        return new()
        {
            Source = new Uri("pack://application:,,,/PaControl;component/Themes/Theme.xaml")
        };
    }
}
