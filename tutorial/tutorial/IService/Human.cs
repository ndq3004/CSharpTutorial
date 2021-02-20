using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.IService
{
    interface Human
    {
        void Run();
        void Drink();
        void Hold();
    }

    interface President
    {
        void Run(int a);
        void Say();
    }
}
