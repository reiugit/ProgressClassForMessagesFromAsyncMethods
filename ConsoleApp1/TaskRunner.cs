namespace ConsoleApp1;

internal static class TaskRunner
{
    // this async method reports to the caller
    internal static async Task RunTaskAsync(IProgress<char> progress)
    {
        for (int i = 65; i <= 90; i++)
        {
            progress.Report((char)i);

            await Task.Delay(200);
        }
    }
}
