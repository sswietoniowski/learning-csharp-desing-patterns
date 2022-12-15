using SingletonLib;

NaiveSingleton ns1 = NaiveSingleton.Instance;
NaiveSingleton ns2 = NaiveSingleton.Instance;

Console.WriteLine(ns1 == ns2);

ThreadSafeSingleton ts = ThreadSafeSingleton.Instance;
ThreadSafeSingleton ts2 = ThreadSafeSingleton.Instance;

Console.WriteLine(ts == ts2);
