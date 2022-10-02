using System;
using System.Collections.Generic;

namespace UniRxPackage.Runtime.Extentions
{
    public class DisposableList : List<IDisposable>, IDisposable
    {
        public void Dispose()
        {
            for (int i = 0; i < Count; i++)
            {
                this[i].Dispose();
            }
            Clear();
        }
    }
}