using System;

namespace UniRxPackage.Runtime.Extentions
{
    public static class ActionExt
    {
        public static IDisposable Subscribe<T>(this Action<T> action, Action<T> handler)
        {
            return new ObservableSubscription<T>(action, handler);
        }
        
        public static IDisposable Subscribe<T1, T2>(this Action<T1, T2> action, Action<T1, T2> handler)
        {
            return new ObservableSubscription<T1, T2>(action, handler);
        }
        
        public static IDisposable Subscribe<T1, T2, T3>(this Action<T1, T2, T3> action, Action<T1, T2, T3> handler)
        {
            return new ObservableSubscription<T1, T2, T3>(action, handler);
        }
        
        public static IDisposable Subscribe<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, Action<T1, T2, T3, T4> handler)
        {
            return new ObservableSubscription<T1, T2, T3, T4>(action, handler);
        }
    }
}