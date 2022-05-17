using System.Collections;

namespace SingletonPattern
{
    public class Singleton
    {
        private static readonly Singleton instance;

        public static Singleton Instance
        {
            get { return instance; }
        }

        static Singleton()
        {
            instance = new Singleton();
        }

        protected Singleton()
        {
            
        }


        public void Foo()
        {
            
        }
    }
}