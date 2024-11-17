using PaControlDemo.Properties.Langs;

namespace PaControlDemo.Tools.Extension;

public class LangExtension : PaControl.Tools.Extension.LangExtension
{
    public LangExtension()
    {
        Source = LangProvider.Instance;
    }
}
