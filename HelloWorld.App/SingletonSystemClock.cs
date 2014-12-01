namespace HelloWorld.App
{
    public class SingletonSystemClock
    {
        private static SystemClock _instance;
        private static readonly object _mutex = new object();

        public static IClock Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_mutex)
                {
                    if (_instance != null) return _instance;

                    _instance = new SystemClock();
                }
              
                return _instance;
            }
        }
    }
}