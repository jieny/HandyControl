using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PaControl.Controls;
using PaControlDemo.Data;
using PaControlDemo.Properties.Langs;
using PaControlDemo.Service;

namespace PaControlDemo.ViewModel;

public class TagDemoViewModel : ViewModelBase
{
    public TagDemoViewModel(DataService dataService)
    {
        DataList = new ObservableCollection<DemoDataModel>(dataService.GetDemoDataList(10));
    }

    public ObservableCollection<DemoDataModel> DataList { get; set; }

    private string _tagName;

    public string TagName
    {
        get => _tagName;
#if NET40
        set => Set(nameof(TagName), ref _tagName, value);
#else
        set => Set(ref _tagName, value);
#endif
    }

    public RelayCommand AddItemCmd => new(() =>
    {
        if (string.IsNullOrEmpty(TagName))
        {
            Growl.Warning(Lang.PlsEnterContent);
            return;
        }

        DataList.Insert(0, new DemoDataModel
        {
            IsSelected = DataList.Count % 2 == 0,
            Name = TagName
        });
        TagName = string.Empty;
    });
}
