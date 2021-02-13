using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial
{
    /// <summary>
    /// Custom indexer  
    /// </summary>
    class DemoStorage
    {
        private string[] strArr = new string[10];

        public delegate void MyDelegate(string msg);

        public string this[int index]
        {
            get
            {
                if(index < 0 || index > strArr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return strArr[index];
            }
            set
            {
                if (index < 0 || index > strArr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                strArr[index] = value;
            }
        }
    }

}
