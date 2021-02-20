using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    class MakeEventHandler
    {
        public event EventHandler ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process started with EventHandler!");
            OnProcessWithEventHandlerCompleted(ResolveEventArgs.Empty);
        }

        public virtual void OnProcessWithEventHandlerCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);
        }
    }
}
