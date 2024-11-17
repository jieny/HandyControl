using System;
using GalaSoft.MvvmLight.Command;
using PaControl.Controls;

namespace PaControlDemo.ViewModel;

public class ImageBrowserDemoViewModel
{
    public RelayCommand OpenImgCmd => new(() =>
        new ImageBrowser(new Uri("pack://application:,,,/Resources/Img/1.jpg")).Show());
}
