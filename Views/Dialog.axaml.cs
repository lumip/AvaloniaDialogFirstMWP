using System;
using Avalonia;
using Avalonia.Markup.Xaml;

using ReactiveUI;
using Avalonia.ReactiveUI;

using AvaloniaDialogFirst.ViewModels;

namespace AvaloniaDialogFirst.Views
{
    public partial class Dialog : ReactiveWindow<DialogViewModel>
    {
        public Dialog()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            // Having this here currently just results in the application closing when it
            // should switch to the actual main window after closing the dialog.
            // I do strongly want to have it here eventually, though.
            // this.WhenActivated(d => d(ViewModel!.ApplyCommand.Subscribe(_ => Close())));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}