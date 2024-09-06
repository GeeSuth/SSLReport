using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLReport
{
    internal static class CrossThreadExtensions
    {
        public static void PerformSafely(this Control target, Action action) 
        { 
            if(target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
