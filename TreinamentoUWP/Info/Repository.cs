using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class Repository
    {
        private static Dictionary<Type, object> _lookup = new Dictionary<Type, object>();

        public static void StoreFactory<T>(Func<T> factory)
        {
            _lookup[typeof(T)] = factory;
        }
        public static T GetObject<T>()
        {
            object o = null;
            if(_lookup.TryGetValue(typeof(T), out o))
            {
                var factory = (Func<T>)o;
                return (T)factory();
            }
            return default(T);
        }
    }
}
