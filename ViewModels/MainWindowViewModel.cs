using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaDialogFirst.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; }

        // the argument should eventually by non-nullable; initialising MainViewModel without results from dialog does not work in proper application
        public MainWindowViewModel(string? text)
        {
            string messageText = (text == null) ? "<no data>" : text;
            Greeting = $"Welcome with {messageText}";
        }
    }
}
