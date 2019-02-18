
using System;
using System.Reflection;

namespace DemoPattern.Core
{
    public abstract class ThreadSafeNestedContructorsBaseSingleton<T>
    {
        public static T Instance
        {
            get
            {
                return SingletonFactory.Instance;
            }
        }

        internal static class SingletonFactory
        {
            
            internal static T Instance;

            static SingletonFactory()
            {
                CreateInstance(typeof(T));
            }

            public static T CreateInstance(Type type)
            {
                return Instance = (T)Activator.CreateInstance(type);
            }
        }
    }
}