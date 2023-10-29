using AdvancedShaderSettings.Models;
using ReactiveUI;
using System.Collections.Generic;

namespace AdvancedShaderSettings.ViewModels;

public class SettingsPageModel : ViewModelBase
{
    private readonly SettingsPage _page;

    public int ColumnCount {
        get => _page.ColumnCount;
        set => this.RaiseAndSetIfChanged(ref _page.ColumnCount, value);
    }

    public IReadOnlyCollection<object>? Rows {
        get => _page.Rows;
        set => this.RaiseAndSetIfChanged(ref _page.Rows, value);
    }


    internal SettingsPageModel(SettingsPage page)
    {
        _page = page;
    }
}
