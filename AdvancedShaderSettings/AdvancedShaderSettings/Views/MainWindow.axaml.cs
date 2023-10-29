using AdvancedShaderSettings.Models;
using AdvancedShaderSettings.ViewModels;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using System;
using System.Linq;

namespace AdvancedShaderSettings.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void OnSelectFileClick(object? sender, RoutedEventArgs e)
    {
        var options = new FilePickerOpenOptions {
            Title = "Open Shader Settings",
            AllowMultiple = false,
        };

        var files = await StorageProvider.OpenFilePickerAsync(options);
        if (files.Count < 1) return;

        if (DataContext is not MainViewModel vm)
            throw new ApplicationException("Failed to get view-model!");

        var document = new SettingsDocument {
            FileName = files.First().TryGetLocalPath(),
        };

        vm.Selected = new SettingsDocumentModel(document);

        // TODO: load file

        if (document.RootPage == null)
            throw new ApplicationException("Failed to load file!");

        vm.CurrentSettingsPage = new SettingsPageModel(document.RootPage);

        //throw new System.NotImplementedException();
    }
}
