using GalaSoft.MvvmLight.Command;
using PaControl.Controls;
using PaControlDemo.UserControl;

namespace PaControlDemo.ViewModel;

public class SpriteDemoViewModel
{
    public RelayCommand OpenCmd => new(() => Sprite.Show(new AppSprite()));
}
