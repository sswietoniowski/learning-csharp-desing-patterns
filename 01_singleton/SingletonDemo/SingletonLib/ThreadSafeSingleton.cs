namespace SingletonLib;
// more ideas how to create a thread safe singleton can be found here:
// https://web.archive.org/web/20080713050413/http://www.yoda.arachsys.com/csharp/singleton.html

public sealed class ThreadSafeSingleton
{
    private static readonly Lazy<ThreadSafeSingleton> Lazy = new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());

    public static ThreadSafeSingleton Instance
    {
        get
        {
            Logger.Log("Instance called.");
            return Lazy.Value;
        }
    }

    private ThreadSafeSingleton()
    {
        Logger.Log("Constructor invoked.");
    }
}