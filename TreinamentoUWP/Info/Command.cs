using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Info
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }

        bool _CanExecute = true;
        public bool CanExecute(object parameter)
        {
            return _CanExecute;
        }

        public async void Execute(object parameter)
        {
            _CanExecute = false;
            RaiseCanExecuteChanged();
            await _FT();
            _CanExecute = true;
            RaiseCanExecuteChanged();
        }
        Func<Task> _FT;
        public Command(Func<Task> Func)
        {
            _FT = Func;
        }
    }
}
