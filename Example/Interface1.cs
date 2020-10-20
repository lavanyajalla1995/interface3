using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    interface Interface1
    {
        void add();
    }

    interface Interface2
    {
        void add();
    }

    class A:Interface1,Interface2
    {
        public void add()
        {
            Console.WriteLine("changes");
        }
        
    }
}
