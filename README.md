# Progress<T> class for messages from async methods

<b>The caller of async methods can process mesages from these async methods.</b>

* The caller creates a Progress<T> instance with a handler for the reported data.
* The caller then calls the async method with the Progress<T> instance as an argument.
* The async method uses the Report method with the payload as an argument.
* The Progress instance then forwards the payload to the previous defined handler.
