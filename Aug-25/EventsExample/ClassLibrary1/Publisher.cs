using System;

namespace ClassLibrary1
{
    public class Publisher
    {
        private MyDelegateType _myEvent;

        public event MyDelegateType MyEvent
        {
            add //executes every time when a new method is added (subscribed) to the event
            {
                _myEvent = value;
            }
            remove //executes every time when an existing method is removed (unsubscribed) from the event
            {
                _myEvent -= value;
            }
        }

        public void RaiseEvent()
        {
            _myEvent(10, 7); //call Add method
        }
    }
}

