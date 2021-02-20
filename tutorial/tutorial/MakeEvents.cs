using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    public delegate void Notify();
    public class MakeEvents
    {
        public event Notify ProcessCompleted;
        
        public void StartProcess()
        {
            Console.WriteLine("Process started!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            Console.WriteLine("Begin completed process!");
            ProcessCompleted?.Invoke();
        }
    }
}
