using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNamespace
{
    public class MyClass:MarshalByRefObject
    {
        public void TraceAppDomain()
        {
            AppDomain currentAppDomain;
            currentAppDomain = AppDomain.CurrentDomain;
            Console.WriteLine(currentAppDomain.FriendlyName);
        }
    }
}
