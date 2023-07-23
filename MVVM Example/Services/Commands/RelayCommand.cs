using System;
using System.Windows.Input;

namespace MVVM_Example.ViewModel.Commands
{
  public class RelayCommand : ICommand
  {
    /// <summary>
    /// Execution logic.
    /// </summary>
    private Action<object> execute;

    /// <summary>
    /// Detects whether command can be executed.
    /// </summary>
    private Func<object, bool> canExecute;

    /// <summary>
    /// Is called when conditions for whether command can be executed or not change.
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
      add { CommandManager.RequerySuggested += value; }
      remove { CommandManager.RequerySuggested -= value; }
    }

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
      this.execute = execute;
      this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
      return canExecute == null || canExecute(parameter);
    }

    public void Execute(object parameter)
    {
      execute(parameter);
    }
  }
}