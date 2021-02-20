using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    public class MakeEventHandlerWithData
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process event handler with data started!");
            OnEventHandlerWithDataCompleted(true);
        }

        public virtual void OnEventHandlerWithDataCompleted(bool isSucessFull)
        {
            ProcessCompleted?.Invoke(this, isSucessFull);
        }
    }

}
