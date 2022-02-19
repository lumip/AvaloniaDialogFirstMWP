using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaDialogFirst.ViewModels;
using AvaloniaDialogFirst.Views;

using System;
using System.Reactive.Linq;

namespace AvaloniaDialogFirst
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // display dialog first
                var dialog = new Dialog()
                {
                    DataContext = new DialogViewModel(),
                };

                // .. and subscribe to its "Apply" button, which returns the dialog result
                dialog.ViewModel!.ApplyCommand
                    /*.ObserveOn(RxApp.MainThreadScheduler).SubscribeOn(RxApp.MainThreadScheduler)*/
                    .Subscribe(result =>
                {
                    Console.WriteLine("dialog apply button hit!");
                    desktop.MainWindow = new MainWindow
                    {
                        DataContext = new MainWindowViewModel(result),
                    };
                    Console.WriteLine("new main window instantiated!");
                    // both of these lines are printed, but the window doesn't change
                });

                // // replacing the MainWindow directly in here works (but is meaningless as I have no data for it)
                // desktop.MainWindow = new MainWindow
                // {
                //     DataContext = new MainWindowViewModel(null),
                // };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}