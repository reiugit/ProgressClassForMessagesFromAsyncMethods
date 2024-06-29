namespace ConsoleApp1;

internal static class ProgressHandler
{
    // this handler that will be called by the Progress<T> instance
    // every time the async method reports to the Progress<T> instance
    internal static void HandleProgress(char x)
    {
        Console.Write(x);
    }
}
