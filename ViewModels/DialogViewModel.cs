using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;
using System.Reactive;

namespace AvaloniaDialogFirst.ViewModels
{
    public class DialogViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, string> ApplyCommand { get; }

        public DialogViewModel()
        {
            ApplyCommand = ReactiveCommand.Create(() => "apply!");
        }
    }
}
