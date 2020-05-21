using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public interface IDialogService
    {
        Task<int> ShowDialogAsync(string title, string caption, string button1, string button2);
    }
}
