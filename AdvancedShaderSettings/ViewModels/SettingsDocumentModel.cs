using AdvancedShaderSettings.Models;

namespace AdvancedShaderSettings.ViewModels;

public class SettingsDocumentModel : ViewModelBase
{
    private readonly SettingsDocument _document;

    public string? FileName {
        get => _document.FileName;
        //set => this.RaiseAndSetIfChanged(ref _document.FileName, value);
    }

    //public SettingsPageModel? RootPage {
    //    get => _document.RootPage != null ? new SettingsPageModel(_document.RootPage) : null;
    //    //set => this.RaiseAndSetIfChanged(ref _fileName, value);
    //}


    internal SettingsDocumentModel(SettingsDocument document)
    {
        _document = document;
    }
}
