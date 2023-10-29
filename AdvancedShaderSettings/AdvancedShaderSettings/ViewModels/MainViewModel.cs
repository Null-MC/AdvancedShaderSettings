using AdvancedShaderSettings.Models;
using ReactiveUI;
using System.Collections.Generic;

namespace AdvancedShaderSettings.ViewModels;

public class MainViewModel : ViewModelBase
{
    private SettingsDocumentModel? _selected;
    public SettingsDocumentModel? Selected {
        get => _selected;
        set => this.RaiseAndSetIfChanged(ref _selected, value);
    }

    private SettingsPageModel? _currentSettingsPage;
    public SettingsPageModel? CurrentSettingsPage {
        get => _currentSettingsPage;
        set => this.RaiseAndSetIfChanged(ref _currentSettingsPage, value);
    }
}

public class MainViewDesignModel : MainViewModel
{
    public MainViewDesignModel()
    {
        var document = new SettingsDocument {
            FileName = @"C:\this\is\a\test.txt",
            RootPage = new SettingsPage {
                ColumnCount = 2,
                Rows = new List<object> {
                    new (),
                    new (),
                    new (),
                },
            },
        };

        Selected = new SettingsDocumentModel(document);
        CurrentSettingsPage = new SettingsPageModel(document.RootPage);
    }
}
