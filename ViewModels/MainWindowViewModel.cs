using System.Diagnostics;
using System.Reactive;
using ReactiveUI;
namespace ALogView.ViewModels;


public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public ReactiveCommand<Unit, Unit> ExampleCommand { get; }

        public MainWindowViewModel()
        {
            ExampleCommand = ReactiveCommand.Create(PerformAction);
        }
        private void PerformAction()
        {
            Debug.WriteLine("The action was called.");
        }
}
