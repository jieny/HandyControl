using PaControlDemo.Data;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class CoverViewModel : DemoViewModelBase<CoverViewDemoModel>
{
    public CoverViewModel(DataService dataService) => DataList = dataService.GetCoverViewDemoDataList();
}
