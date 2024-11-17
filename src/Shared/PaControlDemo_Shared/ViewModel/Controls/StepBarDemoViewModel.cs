using System.Linq;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Command;
using PaControl.Controls;
using PaControlDemo.Data;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class StepBarDemoViewModel : DemoViewModelBase<StepBarDemoModel>
{
    public StepBarDemoViewModel(DataService dataService) => DataList = dataService.GetStepBarDemoDataList();

    private int _stepIndex;

    public int StepIndex
    {
        get => _stepIndex;
#if NET40
        set => Set(nameof(StepIndex), ref _stepIndex, value);
#else
        set => Set(ref _stepIndex, value);
#endif
    }

    /// <summary>
    ///     下一步
    /// </summary>
    public RelayCommand<Panel> NextCmd => new(Next);

    /// <summary>
    ///     上一步
    /// </summary>
    public RelayCommand<Panel> PrevCmd => new(Prev);

    private void Next(Panel panel)
    {
        foreach (var stepBar in panel.Children.OfType<StepBar>())
        {
            stepBar.Next();
        }
    }

    private void Prev(Panel panel)
    {
        foreach (var stepBar in panel.Children.OfType<StepBar>())
        {
            stepBar.Prev();
        }
    }
}
