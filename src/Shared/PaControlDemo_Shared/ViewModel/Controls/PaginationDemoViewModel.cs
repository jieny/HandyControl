using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using PaControl.Data;
using PaControlDemo.Data;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class PaginationDemoViewModel : DemoViewModelBase<DemoDataModel>
{
    /// <summary>
    ///     所有数据
    /// </summary>
    private readonly List<DemoDataModel> _totalDataList;

    /// <summary>
    ///     页码
    /// </summary>
    private int _pageIndex = 1;

    /// <summary>
    ///     页码
    /// </summary>
    public int PageIndex
    {
        get => _pageIndex;
#if NET40
            set => Set(nameof(PageIndex), ref _pageIndex, value);
#else
        set => Set(ref _pageIndex, value);
#endif
    }

    public PaginationDemoViewModel(DataService dataService)
    {
        _totalDataList = dataService.GetDemoDataList(100);
        DataList = _totalDataList.Take(10).ToList();
    }

    /// <summary>
    ///     页码改变命令
    /// </summary>
    public RelayCommand<FunctionEventArgs<int>> PageUpdatedCmd => new(PageUpdated);

    /// <summary>
    ///     页码改变
    /// </summary>
    private void PageUpdated(FunctionEventArgs<int> info)
    {
        DataList = _totalDataList.Skip((info.Info - 1) * 10).Take(10).ToList();
    }
}
