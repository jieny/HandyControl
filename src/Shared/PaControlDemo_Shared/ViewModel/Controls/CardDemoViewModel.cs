using GalaSoft.MvvmLight.Command;
using PaControlDemo.Data;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class CardDemoViewModel : DemoViewModelBase<CardModel>
{
    private readonly DataService _dataService;

    public CardDemoViewModel(DataService dataService)
    {
        _dataService = dataService;
        DataList = dataService.GetCardDataList();
    }

    public RelayCommand AddItemCmd => new(() => DataList.Insert(0, _dataService.GetCardData()));

    public RelayCommand RemoveItemCmd => new(() =>
    {
        if (DataList.Count > 0)
        {
            DataList.RemoveAt(0);
        }
    });
}
