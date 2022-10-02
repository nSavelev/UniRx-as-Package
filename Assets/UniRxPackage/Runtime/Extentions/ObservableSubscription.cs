using System;

namespace UniRxPackage.Runtime.Extentions
{
    public class ObservableSubscription<T> : IDisposable
    {
        private Action<T> _handler;
        private Action<T> _caller;

        public ObservableSubscription(Action<T> caller, Action<T> handler)
        {
            _caller = caller;
            _handler = handler;
            _caller += _handler;
        }

        public void Dispose()
        {
            _caller -= _handler;
            _caller = null;
            _handler = null;
        }
    }
    
    public class ObservableSubscription<T1, T2> : IDisposable
    {
        private Action<T1, T2> _handler;
        private Action<T1, T2> _caller;

        public ObservableSubscription(Action<T1, T2> caller, Action<T1, T2> handler)
        {
            _caller = caller;
            _handler = handler;
            _caller += _handler;
        }

        public void Dispose()
        {
            _caller -= _handler;
            _caller = null;
            _handler = null;
        }
    }
    
    public class ObservableSubscription<T1, T2, T3> : IDisposable
    {
        private Action<T1, T2, T3> _handler;
        private Action<T1, T2, T3> _caller;

        public ObservableSubscription(Action<T1, T2, T3> caller, Action<T1, T2, T3> handler)
        {
            _caller = caller;
            _handler = handler;
            _caller += _handler;
        }

        public void Dispose()
        {
            _caller -= _handler;
            _caller = null;
            _handler = null;
        }
    }
    
    public class ObservableSubscription<T1, T2, T3, T4> : IDisposable
    {
        private Action<T1, T2, T3, T4> _handler;
        private Action<T1, T2, T3, T4> _caller;

        public ObservableSubscription(Action<T1, T2, T3, T4> caller, Action<T1, T2, T3, T4> handler)
        {
            _caller = caller;
            _handler = handler;
            _caller += _handler;
        }

        public void Dispose()
        {
            _caller -= _handler;
            _caller = null;
            _handler = null;
        }
    }
}