using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyNamespace;

namespace test_appdomain
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain;
            currentAppDomain = AppDomain.CurrentDomain;
            Console.WriteLine(currentAppDomain.FriendlyName);

            AppDomain newAppDomain;
            newAppDomain = AppDomain.CreateDomain("My new Appdomain");
            MyClass obj;
            obj = (MyClass)newAppDomain.CreateInstanceAndUnwrap("MyClassLibrary", "MyNamespace.MyClass");
            obj.TraceAppDomain();
        }
    }
}
