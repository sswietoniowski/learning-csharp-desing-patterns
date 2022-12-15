namespace SingletonLib
{
    public sealed class NaiveSingleton
    {
        private static NaiveSingleton? _instance;

        //public static NaiveSingleton Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new NaiveSingleton();
        //        }

        //        return _instance;
        //    }
        //}

        public static NaiveSingleton Instance
        {
            get
            {
                Logger.Log("Instance called.");
                return _instance ??= new NaiveSingleton();
            }
        }

        private NaiveSingleton()
        {
            Logger.Log("Constructor invoked.");
        }
    }
}
