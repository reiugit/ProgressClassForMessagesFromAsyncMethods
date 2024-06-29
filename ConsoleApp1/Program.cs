using ConsoleApp1;

Console.WriteLine();
Console.WriteLine("Reporting to the caller of an async method using the Progress<T> class");
Console.WriteLine("----------------------------------------------------------------------\n\n");
Console.Write("The Progress instance reports the following letters:\n\n    ");

// using the Progress<T> class to report to the caller of an async method
var progress = new Progress<char>(ProgressHandler.HandleProgress);

// calling the async method with the Progress<T> instance as an argument
await TaskRunner.RunTaskAsync(progress);


Console.WriteLine("\n\n\n---------------------------------------------------------------------\n");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
