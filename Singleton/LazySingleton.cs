using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class LazySingleton
    {
        private static int counter = 0;
        private LazySingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static readonly Lazy<LazySingleton> Instancelock =
                    new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton GetInstance
        {
            get
            {
                return Instancelock.Value;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
