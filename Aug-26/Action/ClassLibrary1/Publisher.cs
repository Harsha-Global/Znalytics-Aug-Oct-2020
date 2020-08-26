using System;

namespace ClassLibrary1
{
    public class Publisher
    {
        //auto implemented event
        public event Action<int, int> MyEvent;

        public void RaiseEvent()
        {
            MyEvent(10, 7); //call Add method
        }
    }
}

