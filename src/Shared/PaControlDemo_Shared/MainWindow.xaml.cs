using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using PaControl.Controls;
using PaControl.Tools;
using PaControlDemo.Data;
using PaControlDemo.Tools;
using PaControlDemo.UserControl;
using PaControlDemo.ViewModel;

namespace PaControlDemo;

public partial class MainWindow
{
    public MainWindow() => InitializeComponent();

    protected override void OnContentRendered(EventArgs e)
    {
        base.OnContentRendered(e);

        DataContext = ViewModelLocator.Instance.Main;
        NonClientAreaContent = new NonClientAreaContent();
        ControlMain.Content = new MainWindowContent();

        GlobalShortcut.Init(new List<KeyBinding>
        {
            new(ViewModelLocator.Instance.Main.GlobalShortcutInfoCmd, Key.I, ModifierKeys.Control | ModifierKeys.Alt),
            new(ViewModelLocator.Instance.Main.GlobalShortcutWarningCmd, Key.E, ModifierKeys.Control | ModifierKeys.Alt),
            new(ViewModelLocator.Instance.Main.OpenDocCmd, Key.F1, ModifierKeys.None),
            new(ViewModelLocator.Instance.Main.OpenCodeCmd, Key.F12, ModifierKeys.None)
        });

        Dialog.SetToken(this, MessageToken.MainWindow);
        WindowAttach.SetIgnoreAltF4(this, true);

        Messenger.Default.Send(true, MessageToken.FullSwitch);
        Messenger.Default.Send(AssemblyHelper.CreateInternalInstance($"UserControl.{MessageToken.PracticalDemo}"), MessageToken.LoadShowContent);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        if (GlobalData.NotifyIconIsShow)
        {
            MessageBox.Info(Properties.Langs.Lang.AppClosingTip, Properties.Langs.Lang.Tip);
            Hide();
            e.Cancel = true;
        }
        else
        {
            base.OnClosing(e);
        }
    }
}
