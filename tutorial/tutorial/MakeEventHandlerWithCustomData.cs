using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    class MakeEventHandlerWithCustomData
    {
        public event EventHandler<ProcessEventArg> ProcessCustomCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Start Process with custom data event handler");
            ProcessEventArg dataE = new ProcessEventArg();
            dataE.IsSuccessfull = true;
            dataE.CompletedTime = DateTime.Now;
            OnProcessCompleted(dataE);
        }

        public virtual void OnProcessCompleted(ProcessEventArg e)
        {
            ProcessCustomCompleted?.Invoke(this, e);
        }
    }

    class ProcessEventArg
    {
        public bool IsSuccessfull;
        public DateTime CompletedTime;
    }
}
