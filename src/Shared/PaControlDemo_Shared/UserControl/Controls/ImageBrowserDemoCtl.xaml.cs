
using System;

namespace PaControlDemo.UserControl;

public partial class ImageBrowserDemoCtl : IDisposable
{
    public ImageBrowserDemoCtl()
    {
        InitializeComponent();
    }

    public void Dispose()
    {
        ImageViewerDemo.Dispose();
    }
}
