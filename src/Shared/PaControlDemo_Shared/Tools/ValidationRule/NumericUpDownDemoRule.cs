using System.Globalization;
using System.Windows.Controls;

namespace PaControlDemo.Tools;

public class NumericUpDownDemoRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (value is not double doubleValue)
        {
            return new ValidationResult(false, PaControl.Properties.Langs.Lang.FormatError);
        }

        return doubleValue % 2 > double.Epsilon
            ? new ValidationResult(false, Properties.Langs.Lang.Error)
            : ValidationResult.ValidResult;
    }
}
