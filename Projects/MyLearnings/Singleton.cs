using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private Singleton() { }

        private static Singleton _instance = null;
        private static readonly object mutex = new object();

        public static Singleton GetInstance
        {
            get
            {
                lock (mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
